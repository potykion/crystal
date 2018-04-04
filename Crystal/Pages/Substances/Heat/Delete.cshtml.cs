using System.Threading.Tasks;
using Crystal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Crystal.Pages.Substances.Heat
{
    public class DeleteModel : PageModel
    {
        private readonly Crystal.Models.CrystalContext _context;

        public DeleteModel(Crystal.Models.CrystalContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HeatTablLanguage = await _context.HeatTablLanguage.FindAsync(id);

            if (HeatTablLanguage != null)
            {
                _context.HeatTablLanguage.Remove(HeatTablLanguage);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
