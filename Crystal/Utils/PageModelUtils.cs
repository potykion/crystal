using Microsoft.AspNetCore.Routing;

namespace Crystal.Utils
{
    public static class PageModelUtils
    {
        public static int GetLanguageId(this RouteData routeData)
        {
            var culture = routeData.Values["lang"] as string;
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