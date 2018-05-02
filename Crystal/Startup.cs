using System.Collections.Generic;
using System.Globalization;
using Crystal.Models;
using Crystal.Utils;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Localization.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Crystal
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // add authentication
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie();

            // to get user in templates
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // add localization
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddMvc()
                .AddRazorPagesOptions(options =>
                    options.Conventions.Add(new GlobalTemplatePageRouteModelConvention())
                )
                .AddViewLocalization()
                .AddDataAnnotationsLocalization();

            // add authorization
            services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminOnly", policy => policy.RequireRole("Administrator"));
                options.AddPolicy("UserOnly", policy => policy.RequireRole("User", "Administrator"));
            });

            // add DB
            var connection = Configuration.GetConnectionString("CrystalDatabase");
            services.AddDbContext<CrystalContext>(options => options.UseSqlServer(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // use localization
            var supportedCultures = new List<CultureInfo>
            {
                new CultureInfo("ru"),
                new CultureInfo("en")
            };

            var requestLocalizationOptions = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("ru"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures,
            };
            requestLocalizationOptions.RequestCultureProviders = new List<IRequestCultureProvider>(
                new RequestCultureProvider[]
                {
                    new CustomRouteDataRequestCultureProvider
                    {
                        Options = requestLocalizationOptions
                    },
                    new CookieRequestCultureProvider()
                });
            app.UseRequestLocalization(requestLocalizationOptions);

            // use auth
            app.UseAuthentication();


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseMvc();
        }
    }
}