using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;

namespace Crystal.Utils
{
    public static class RequestUtils
    {
        /// <summary>
        /// Get language id from HttpRequest.
        /// </summary>
        /// <example>
        /// Use <c>PageModel.Request</c> to get language id.
        /// <code>
        /// var languageId = Request.GetLanguageId();
        /// </code>
        /// </example>
        public static int GetLanguageId(this HttpRequest request)
        {
            var rcf = request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rcf.RequestCulture.Culture.Name;
            
            var languageTag = culture.Substring(0, 2);

            return MapLanguageTagToId(languageTag);
        }

        private static int MapLanguageTagToId(string languageTag)
        {
            var languageId = 1;
            switch (languageTag)
            {
                case "ru":
                    languageId = 1;
                    break;
                case "en":
                    languageId = 2;
                    break;
            }

            return languageId;
        }
    }
}