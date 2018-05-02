using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crystal.Models;
using Crystal.Utils;
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
        public IDictionary<int, BibliogrLanguage> References { get; set; }

        public async Task OnGetAsync(string systemUrl)
        {
            var headClue = _contextUtils.GetHeadClueBySystemUrl(systemUrl);

            var heatTablValues = _context.HeatTablLanguage
                .Include(h => h.HeatTabl)
                .Include(h => h.HeatTabl.BknumberNavigation.BibliogrLanguage)
                .Where(heat => heat.HeatTabl.HeadClue == headClue)
                .Where(e => e.LanguageId == RouteData.GetLanguageId());

            HeatTablLanguage = await heatTablValues.ToListAsync();

            var bibliogrLanguage = await _context.BibliogrLanguage
                .Include(b => b.Bibliogr)
                .Where(b => b.LanguageId == RouteData.GetLanguageId())
                .ToDictionaryAsync(b => b.BibliogrId, b => b);

            References = HeatTablLanguage
                .ToDictionary(h => h.HeatTablId, h =>
                    h.HeatTabl.Bknumber.HasValue ? bibliogrLanguage[(int) h.HeatTabl.Bknumber] : null
                );
        }
    }
}