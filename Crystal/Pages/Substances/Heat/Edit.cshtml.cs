using System.Linq;
using System.Threading.Tasks;
using Crystal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Crystal.Pages.Substances.Heat
{
    public class EditModel : PageModel
    {
        private readonly Crystal.Models.CrystalContext _context;

        public EditModel(Crystal.Models.CrystalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public HeatTablLanguage HeatTablLanguage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HeatTablLanguage = await _context.HeatTablLanguage
                .Include(h => h.HeatTabl).FirstOrDefaultAsync(m => m.Id == id);

            if (HeatTablLanguage == null)
            {
                return NotFound();
            }
           ViewData["HeatTablId"] = new SelectList(_context.HeatTablInvariant, "Id", "Id");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(HeatTablLanguage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HeatTablLanguageExists(HeatTablLanguage.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool HeatTablLanguageExists(int id)
        {
            return _context.HeatTablLanguage.Any(e => e.Id == id);
        }
    }
}
