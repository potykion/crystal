using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Crystal.Pages.Account
{
    public class LogoutPageModel : PageModel
    {
        public async Task<IActionResult> OnGetAsync(string returnUrl = "/Index")
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToPage(returnUrl);
        }
        
        public async Task<IActionResult> OnPostAsync(string returnUrl = "/Index")
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToPage(returnUrl);
        }
    }
}