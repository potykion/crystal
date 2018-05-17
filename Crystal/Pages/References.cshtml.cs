using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Crystal.Pages
{
    [Authorize(Policy = "UserOnly")]
    public class ReferencesModel : PageModel
    {
        public IActionResult OnGet(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return NotFound();
            }

            var pdfPath = BuildPdfPath(name);
            return File(pdfPath, "application/pdf");
        }

        private static string BuildPdfPath(string name)
        {
            return name.EndsWith(".pdf")
                ? $"pdf/{name}"
                : $"pdf/{name}.pdf";
        }
    }
}