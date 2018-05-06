using System.Collections.Generic;
using System.Globalization;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Crystal.Utils
{
    public class LanguageFilter : IPageFilter
    {
        private readonly IList<CultureInfo> _supportedCultures;

        public LanguageFilter(IList<CultureInfo> supportedCultures)
        {
            _supportedCultures = supportedCultures;
        }

        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
            var culture = context.HttpContext.Request.Path.Value.Split('/')[1];

            try
            {
                _supportedCultures.Contains(new CultureInfo(culture));
            }
            catch (CultureNotFoundException e)
            {
                context.HttpContext.Response.Redirect("/ru" + context.HttpContext.Request.Path);
            }
        }

        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
        }

        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
        }
    }
}