using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Crystal.Models;

namespace Crystal.Pages.HeadTabl
{
    public class IndexModel : PageModel
    {
        private readonly Crystal.Models.CrystalContext _context;

        public IndexModel(Crystal.Models.CrystalContext context)
        {
            _context = context;
        }

        public IList<HeadTablInvariant> HeadTablInvariant { get;set; }

        public async Task OnGetAsync()
        {
            HeadTablInvariant = await _context.HeadTablInvariant.ToListAsync();
        }
    }
}
