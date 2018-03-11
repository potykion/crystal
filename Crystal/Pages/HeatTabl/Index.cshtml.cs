using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crystal.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Crystal.Pages.HeatTabl
{
    public class IndexModel : PageModel
    {
        private readonly CrystalContext _context;

        public IndexModel(CrystalContext context)
        {
            _context = context;
        }

        public IList<HeatTablLanguage> HeatTablLanguage { get; set; }

        public async Task OnGetAsync(int? headClue)
        {
            IQueryable<HeatTablLanguage> heatTablValues = _context.HeatTablLanguage
                .Include(h => h.HeatTabl)
                .Include(h => h.HeatTabl.BknumberNavigation.BibliogrLanguage);

            if (headClue.HasValue)
                heatTablValues = heatTablValues.Where(heat => heat.HeatTabl.HeadClue == headClue);

            HeatTablLanguage = await heatTablValues.ToListAsync();
        }
    }
}