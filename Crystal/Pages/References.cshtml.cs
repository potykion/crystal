using Crystal.Utils;
using Microsoft.AspNetCore.Authorization;

namespace Crystal.Pages
{
    [Authorize(Policy = "UserOnly")]
    public class ReferencesModel : FilePageModel
    {
        protected override string BuildPath(string name)
        {
            return name.EndsWith(".pdf")
                ? $"pdf/{name}"
                : $"pdf/{name}.pdf";
        }

        protected override string GetFileMimetype()
        {
            return "application/pdf";
        }
    }
}