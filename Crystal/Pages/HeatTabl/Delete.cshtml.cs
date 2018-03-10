using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Crystal.Models;

namespace Crystal.Pages.HeatTabl
{
    public class DeleteModel : PageModel
    {
        private readonly Crystal.Models.CrystalContext _context;

        public DeleteModel(Crystal.Models.CrystalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public HeatTablInvariant HeatTablInvariant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HeatTablInvariant = await _context.HeatTablInvariant
                .Include(h => h.BknumberNavigation)
                .Include(h => h.HeadClueNavigation).FirstOrDefaultAsync(m => m.Id == id);

            if (HeatTablInvariant == null)
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

            HeatTablInvariant = await _context.HeatTablInvariant.FindAsync(id);

            if (HeatTablInvariant != null)
            {
                _context.HeatTablInvariant.Remove(HeatTablInvariant);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
