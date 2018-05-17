using Crystal.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Crystal.Pages
{
    public class ImagesModel : FilePageModel
    {
        protected override string GetFileMimetype()
        {
            return "image/gif";
        }

        protected override string BuildPath(string name)
        {
            return name.EndsWith(".gif")
                ? $"images/{name}"
                : $"images/{name}.gif";
        }
    }
}