using System.Threading.Tasks;
using Crystal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Crystal.Pages.HeadTabl
{
    public class EditModel : PageModel
    {
        private readonly CrystalContext _context;

        public EditModel(CrystalContext context)
        {
            _context = context;
        }

        [BindProperty] public HeadTablLanguage HeadTablLanguage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HeadTablLanguage = await _context.HeadTablLanguage
                .Include(h => h.HeadTabl)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);

            if (HeadTablLanguage == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var headTablToUpdate = await _context.HeadTablLanguage
                .Include(h => h.HeadTabl)
                .FirstOrDefaultAsync(h => h.Id == id);

            var updated = await TryUpdateModelAsync(
                headTablToUpdate,
                "HeadTablLanguage",
                h => h.System, h => h.HeadTabl, h => h.Expert
            );

            if (updated)
            {
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}