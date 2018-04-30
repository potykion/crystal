using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Crystal.Models;

namespace Crystal.Pages.Substances.Thermal_Expansion
{
    public class IndexModel : PageModel
    {
        private readonly Crystal.Models.CrystalContext _context;

        public IndexModel(Crystal.Models.CrystalContext context)
        {
            _context = context;
        }

        public IList<HeatExpnLanguage> HeatExpnLanguage { get; set; }

        public async Task OnGetAsync()
        {
            HeatExpnLanguage = await _context.HeatExpnLanguage
                .Where(h => h.DataType == 0)
                .Include(h => h.BknumberNavigation)
                .Include(h => h.SingTabl)
                .ToListAsync();
        }
    }
}