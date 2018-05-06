using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Crystal.Utils
{
    public static class PageModelUtils
    {
        public static string GetLanguage(this PageModel pageModel)
        {
            try
            {
                return pageModel.RouteData.Values["lang"] as string;
            }
            catch (KeyNotFoundException e)
            {
                return "ru";
            }
        }

        public static int GetLanguageId(this PageModel pageModel)
        {
            var culture = pageModel.GetLanguage();
            return CultureToLanguageCode(culture);
        }

        private static int CultureToLanguageCode(string culture)
        {
            switch (culture)
            {
                case "ru":
                    return 1;
                case "en":
                    return 2;
                default:
                    return 1;
            }
        }
    }
}