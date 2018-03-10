using System.Collections.Generic;
using System.Threading.Tasks;
using Crystal.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Crystal.Pages.HeadTabl
{
    public class PropertiesIndex : PageModel
    {
        private readonly CrystalContext _context;

        public PropertiesIndex(CrystalContext context)
        {
            _context = context;
        }

        public IList<PropertiesLanguage> PropertiesLanguage { get; set; }

        public async Task OnGetAsync()
        {
            PropertiesLanguage = await _context.PropertiesLanguage
                .Include(p => p.Properties)
                .ToListAsync();
        }
    }
}