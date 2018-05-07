using System;

namespace Crystal.Utils
{
    public class UrlBuilder
    {
        public string BuildSubstanceLink(string language, string systemUrl, string method = "Index")
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
        public string BuildPropertyLink(string language, string systemUrl, string propertyUrl, string method = "Index")
        {
            if (method != "Edit" && method != "Create" && method != "Delete")
            {
                return $"/{language}/Substances/{propertyUrl}/{systemUrl}";
            }

            return $"/{language}/Substances/{propertyUrl}/{method}/{systemUrl}";
        }

        public string ChangeLanguageUrl(string url, string language)
        {
            var urlWithoutLanguage = url;
            try
            {
                urlWithoutLanguage = url.Substring(url.IndexOf("/", 1, StringComparison.Ordinal));
            }
            catch (ArgumentOutOfRangeException e)
            {
            }

            return $"/{language}{urlWithoutLanguage}";
        }
    }
}