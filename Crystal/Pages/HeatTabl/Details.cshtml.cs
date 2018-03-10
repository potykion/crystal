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
    public class DetailsModel : PageModel
    {
        private readonly Crystal.Models.CrystalContext _context;

        public DetailsModel(Crystal.Models.CrystalContext context)
        {
            _context = context;
        }

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
    }
}
