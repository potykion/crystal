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
    public class IndexModel : PageModel
    {
        private readonly Crystal.Models.CrystalContext _context;

        public IndexModel(Crystal.Models.CrystalContext context)
        {
            _context = context;
        }

        public IList<HeatTablInvariant> HeatTablInvariant { get;set; }

        public async Task OnGetAsync()
        {
            HeatTablInvariant = await _context.HeatTablInvariant
                .Include(h => h.BknumberNavigation)
                .Include(h => h.HeadClueNavigation).ToListAsync();
        }
    }
}
