using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Crystal.Utils
{
    [HtmlTargetElement("label", Attributes = ForAttributeName)]
    public class HtmlLabelTagHelper : LabelTagHelper
    {
        private const string ForAttributeName = "asp-for";

        public HtmlLabelTagHelper(IHtmlGenerator generator) :
            base(generator)
        {
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            await base.ProcessAsync(context, output);
            
            var initialContent = output.Content.GetContent();
            var contentAsHtml = WebUtility.HtmlDecode(initialContent);
            
            output.Content.Clear();
            output.Content.AppendHtml(contentAsHtml);
        }
    }
}