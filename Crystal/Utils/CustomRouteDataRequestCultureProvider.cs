using System;
using System.Globalization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Localization.Routing;

namespace Crystal.Utils
{
    public class CustomRouteDataRequestCultureProvider : RouteDataRequestCultureProvider
    {
        /// <inheritdoc />
        /// <summary>
        /// Copied from here:
        /// https://stackoverflow.com/a/42536548/5500609
        /// </summary>
        public override Task<ProviderCultureResult> DetermineProviderCultureResult(HttpContext httpContext)
        {
            if (httpContext == null)
            {
                throw new ArgumentNullException(nameof(httpContext));
            }

            // /en/Substances > en
            // /Substances > Substances  
            var culture = httpContext.Request.Path.Value.Split('/')[1];

            try
            {
                Options.SupportedCultures.Contains(new CultureInfo(culture));
            }
            catch (CultureNotFoundException e)
            {
                culture = Options.DefaultRequestCulture.Culture.DisplayName;
            }

            var uiCulture = culture;
            var providerResultCulture = new ProviderCultureResult(culture, uiCulture);

            return Task.FromResult(providerResultCulture);
        }
    }
}