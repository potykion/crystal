using System.Threading.Tasks;
using Crystal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Crystal.Pages.Substances.Density
{
    public class DeleteModel : PageModel
    {
        private readonly Crystal.Models.CrystalContext _context;

        public DeleteModel(Crystal.Models.CrystalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DensTablLanguage DensTablLanguage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DensTablLanguage = await _context.DensTablLanguage
                .Include(d => d.BknumberNavigation)
                .Include(d => d.HeadClueNavigation)
                .Include(d => d.SingTabl).FirstOrDefaultAsync(m => m.Id == id);

            if (DensTablLanguage == null)
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

            DensTablLanguage = await _context.DensTablLanguage.FindAsync(id);

            if (DensTablLanguage != null)
            {
                _context.DensTablLanguage.Remove(DensTablLanguage);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
