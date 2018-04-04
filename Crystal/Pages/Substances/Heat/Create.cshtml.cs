using System.Threading.Tasks;
using Crystal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Crystal.Pages.Substances.Heat
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
        ViewData["HeatTablId"] = new SelectList(_context.HeatTablInvariant, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public HeatTablLanguage HeatTablLanguage { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.HeatTablLanguage.Add(HeatTablLanguage);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}