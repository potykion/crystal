using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crystal.Models;
using Crystal.Utils;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Crystal.Pages.Substances.Melt
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

        public IList<PlavTablLanguage> PlavTablLanguage { get; set; }
        
        public IDictionary<int, BibliogrLanguage> References { get; set; }
        
        

        public async Task OnGetAsync(string systemUrl )
        {
            var headClue = _contextUtils.GetHeadClueBySystemUrl(systemUrl);

            var substancePlavTabl = _context.PlavTablLanguage
                .Include(m => m.PlavTabl)
                .Where(m => m.PlavTabl.HeadClue == headClue)
                .Where(m => m.LanguageId == this.GetLanguageId());

            

            PlavTablLanguage = await substancePlavTabl.ToListAsync();

            

            
            var bibliogrLanguage = await _context.BibliogrLanguage
                .Include(b => b.Bibliogr)
                .Where(b => b.LanguageId == this.GetLanguageId())
                .ToDictionaryAsync(b => b.BibliogrId, b => b);

            References = PlavTablLanguage
                .ToDictionary(h => h.PlavTablId, h =>
                    h.PlavTabl.Bknumber.HasValue ? bibliogrLanguage[(int) h.PlavTabl.Bknumber] : null
                );
            
        }
    }
}