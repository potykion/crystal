using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Http;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Threading.Tasks;
using Crystal.Auth;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;

namespace Crystal.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly IConfiguration _configuration;
        [BindProperty] public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        [TempData] public string ErrorMessage { get; set; }


        public LoginModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public class InputModel
        {
            [Required] [EmailAddress] public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            // Clear the existing external cookie
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = "/Index")
        {
            ReturnUrl = returnUrl;

            if (ModelState.IsValid)
            {
                var user = await AuthenticateUser(Input.Email, Input.Password);

                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Email),
                    new Claim(ClaimTypes.Role, user.Role),
                };

                await SaveClaimsToCookie(claims);

                return RedirectToPage(returnUrl);
            }

            // Something failed. Redisplay the form.
            return Page();
        }

        private async Task SaveClaimsToCookie(List<Claim> claims)
        {
            var claimsIdentity = new ClaimsIdentity(
                claims,
                CookieAuthenticationDefaults.AuthenticationScheme
            );

            var authProperties = new AuthenticationProperties
            {
                IsPersistent = true,
            };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties
            );
        }

        private async Task<User> AuthenticateUser(string email, string password)
        {
            var isAdmin = CheckAdminCredentials(Input.Email, Input.Password);

            if (isAdmin)
            {
                return new User
                {
                    Email = Input.Email,
                    Role = "Administrator"
                };
            }

            var loginData = await MakeSSOCall(Input.Email, Input.Password);
            var loginSuccessful = !string.IsNullOrEmpty(loginData);

            if (loginSuccessful)
            {
                return new User
                {
                    Email = Input.Email,
                    Role = "User",
                    SSOData = loginData
                };
            }

            return null;
        }

        private bool CheckAdminCredentials(string login, string password)
        {
            return _configuration["Admin:Login"] == login &&
                   _configuration["Admin:Password"] == password;
        }

        private async Task<string> MakeSSOCall(string login, string password)
        {
            var url = "http://sso.imet-db.ru/sso/json_auth.ashx";

            var values = new Dictionary<string, string>
            {
                {"mode", "login"},
                {"login", login},
                {"pass", password}
            };
            var content = new FormUrlEncodedContent(values);

            var client = new HttpClient();
            var response = await client.PostAsync(url, content);

            var responseData = await response.Content.ReadAsStringAsync();

            var parsedData = JObject.Parse(responseData);
            var loginData = parsedData["Data"].ToString();
            return loginData;
        }
    }
}