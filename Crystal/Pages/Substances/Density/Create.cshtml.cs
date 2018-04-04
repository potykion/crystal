using System.Threading.Tasks;
using Crystal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Crystal.Pages.Substances.Density
{
    public class CreateModel : PageModel
    {
        private readonly Crystal.Models.CrystalContext _context;

        public CreateModel(Crystal.Models.CrystalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["Bknumber"] = new SelectList(_context.BibliogrInvariant, "Bknumber", "Bknumber");
        ViewData["HeadClue"] = new SelectList(_context.HeadTablInvariant, "HeadClue", "Help");
        ViewData["HeadClue"] = new SelectList(_context.SingTabl, "HeadClue", "SingType");
            return Page();
        }

        [BindProperty]
        public DensTablLanguage DensTablLanguage { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.DensTablLanguage.Add(DensTablLanguage);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}