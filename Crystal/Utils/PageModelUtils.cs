using System;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Server.Kestrel.Transport.Libuv.Internal.Networking;

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

        static string BuildSubstanceLink(string language, string systemUrl, string method = "Index")
        {
            if (string.IsNullOrEmpty(systemUrl))
            {
                return $"/{language}/Substances/{method}";
            }
            else
            {
                if (method != "Edit" && method != "Create" && method != "Delete")
                {
                    method = "Details";
                }

                return $"/{language}/Substances/{method}/{systemUrl}";
            }
        }

        // todo pass to href
        static string BuildPropertyLink(string language, string systemUrl, string propertyUrl, string method = "Index")
        {
            if (method != "Edit" && method != "Create" && method != "Delete")
            {
                return $"/{language}/Substances/{propertyUrl}/{systemUrl}";
            }

            return $"/{language}/Substances/{propertyUrl}/{method}/{systemUrl}";
        }

        // todo language toggle link as ChangeLanguageUrl call
        static string ChangeLanguageUrl(string url, string language)
        {
            var urlWithoutLanguage = url.Substring(url.IndexOf("/", 1, StringComparison.Ordinal));
            return $"/{language}{urlWithoutLanguage}";
        }
    }
}