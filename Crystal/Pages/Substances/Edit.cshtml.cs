using System.Threading.Tasks;
using Crystal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Crystal.Pages.Substances
{
    public class EditModel : PageModel
    {
        private readonly CrystalContext _context;

        public EditModel(CrystalContext context)
        {
            _context = context;
        }

        [BindProperty] public HeadTablLanguage HeadTablLanguage { get; set; }
        [BindProperty] public HeadTablInvariant HeadTablInvariant { get; set; }

        public async Task<IActionResult> OnGetAsync(string systemUrl)
        {
            HeadTablLanguage = await _context.HeadTablLanguage
                .Include(h => h.HeadTabl)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.HeadTabl.SystemUrl == systemUrl);

            HeadTablInvariant = HeadTablLanguage.HeadTabl;

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string systemUrl)
        {
            var headTablToUpdate = await _context.HeadTablLanguage
                .Include(h => h.HeadTabl)
                .FirstOrDefaultAsync(m => m.HeadTabl.SystemUrl == systemUrl);

            await TryUpdateModelAsync(
                headTablToUpdate,
                "HeadTablLanguage",
                h => h.Expert
            );

            await TryUpdateModelAsync(
                headTablToUpdate.HeadTabl,
                "HeadTablInvariant",
                h => h.Help, h => h.System
            );

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}