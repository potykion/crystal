using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Crystal.Utils
{
    public abstract class FilePageModel : PageModel
    {
        public IActionResult OnGet(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return NotFound();
            }

            var path = BuildPath(name);
            
            return File(path, GetFileMimetype());
        }

        protected abstract string BuildPath(string name);

        protected abstract string GetFileMimetype();
    }
}