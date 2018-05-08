using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crystal.Models;
using Crystal.Utils;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Crystal.Pages.Substances.Piezoelectric_Coupling
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

        public IList<MechTablLanguage> MechTablLanguage { get; set; }
        
        public IDictionary<int, BibliogrLanguage> References { get; set; }
        
        
        public IList<SingTabl> SingTabl { get; set; }
        

        public async Task OnGetAsync(string systemUrl , string sing)
        {
            var headClue = _contextUtils.GetHeadClueBySystemUrl(systemUrl);

            var substanceMechTabl = _context.MechTablLanguage
                .Include(m => m.MechTabl)
                .Where(m => m.MechTabl.HeadClue == headClue)
                .Where(m => m.LanguageId == this.GetLanguageId());

            
            if (!string.IsNullOrEmpty(sing))
            {
                substanceMechTabl = substanceMechTabl.Where(m => m.MechTabl.SingCode == sing);
            }
            

            MechTablLanguage = await substanceMechTabl.ToListAsync();

            
            SingTabl = await _context.SingTabl
                .Where(s => s.HeadClue == headClue)
                .ToListAsync();
            

            
            var bibliogrLanguage = await _context.BibliogrLanguage
                .Include(b => b.Bibliogr)
                .Where(b => b.LanguageId == this.GetLanguageId())
                .ToDictionaryAsync(b => b.BibliogrId, b => b);

            References = MechTablLanguage
                .ToDictionary(h => h.MechTablId, h =>
                    h.MechTabl.Bknumber.HasValue ? bibliogrLanguage[(int) h.MechTabl.Bknumber] : null
                );
            
        }
    }
}