using System.Threading.Tasks;
using Crystal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Crystal.Pages.Substances
{
    public class DeleteModel : PageModel
    {
        private readonly Crystal.Models.CrystalContext _context;

        public DeleteModel(Crystal.Models.CrystalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public HeadTablLanguage HeadTablLanguage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HeadTablLanguage = await _context.HeadTablLanguage
                .Include(h => h.HeadTabl).FirstOrDefaultAsync(m => m.Id == id);

            if (HeadTablLanguage == null)
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

            HeadTablLanguage = await _context.HeadTablLanguage.FindAsync(id);

            if (HeadTablLanguage != null)
            {
                _context.HeadTablLanguage.Remove(HeadTablLanguage);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
