using System;
using System.Collections.Generic;
using System.Linq;

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

        public string BuildPropertyLink(
            string language, string property, string method = "Index", string system = "", string queryParams = ""
        )
        {
            var resultUrl = $"/{language}/Substances/{property}";

            if (method == "Edit" || method == "Create" || method == "Delete")
            {
                resultUrl = $"{resultUrl}/{method}";
            }

            if (!string.IsNullOrEmpty(system))
            {
                resultUrl = $"{resultUrl}/{system}";
            }

            if (!string.IsNullOrEmpty(queryParams))
            {
                resultUrl = $"{resultUrl}?{queryParams}";
            }

            return resultUrl;
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