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
    public class DetailsModel : PageModel
    {
        private readonly Crystal.Models.CrystalContext _context;

        public DetailsModel(Crystal.Models.CrystalContext context)
        {
            _context = context;
        }

        public HeatExpnLanguage HeatExpnLanguage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HeatExpnLanguage = await _context.HeatExpnLanguage
                .Include(h => h.BknumberNavigation)
                .Include(h => h.SingTabl).FirstOrDefaultAsync(m => m.Id == id);

            if (HeatExpnLanguage == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
