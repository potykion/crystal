using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crystal.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Crystal.Pages.Substances.Heat
{
    public class IndexModel : PageModel
    {
        private readonly CrystalContext _context;
        private readonly ContextUtils _contextUtils;


        public IndexModel(CrystalContext context)
        {
            _context = context;
            _contextUtils = new ContextUtils(_context);
        }

        public IList<HeatTablLanguage> HeatTablLanguage { get; set; }

        public async Task OnGetAsync(string systemUrl)
        {
            var headClue = _contextUtils.GetHeadClueBySystemUrl(systemUrl);

            var heatTablValues = _context.HeatTablLanguage
                .Include(h => h.HeatTabl)
                .Include(h => h.HeatTabl.BknumberNavigation.BibliogrLanguage)
                .Where(heat => heat.HeatTabl.HeadClue == headClue);

            HeatTablLanguage = await heatTablValues.ToListAsync();
        }
    }
}