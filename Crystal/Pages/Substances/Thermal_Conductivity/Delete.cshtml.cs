using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Crystal.Models;

namespace Crystal.Pages.Substances.Thermal_Conductivity
{
    public class DeleteModel : PageModel
    {
        private readonly Crystal.Models.CrystalContext _context;

        public DeleteModel(Crystal.Models.CrystalContext context)
        {
            _context = context;
        }

        [BindProperty] public HeatExpnLanguage HeatExpnLanguage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HeatExpnLanguage = await _context.HeatExpnLanguage
                .Include(h => h.HeatExpn)
                .Include(h => h.HeatExpn.BknumberNavigation)
                .Include(h => h.HeatExpn.SingTabl)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (HeatExpnLanguage == null)
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

            HeatExpnLanguage = await _context.HeatExpnLanguage.FindAsync(id);

            if (HeatExpnLanguage != null)
            {
                _context.HeatExpnLanguage.Remove(HeatExpnLanguage);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}