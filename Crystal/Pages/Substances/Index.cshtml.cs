using System.Collections.Generic;
using System.Threading.Tasks;
using Crystal.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Crystal.Pages.Substances
{
    public class IndexModel : PageModel
    {
        private readonly CrystalContext _context;

        public IndexModel(CrystalContext context)
        {
            _context = context;
        }

        public IList<HeadTablLanguage> HeadTablLanguage { get; set; }

        public async Task OnGetAsync()
        {
            HeadTablLanguage = await _context.HeadTablLanguage
                .Include(h => h.HeadTabl).ToListAsync();
        }
    }
}