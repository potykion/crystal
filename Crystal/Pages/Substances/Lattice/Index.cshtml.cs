using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crystal.Models;
using Crystal.Utils;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Crystal.Pages.Substances.Lattice
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

        public IList<ElemTablLanguage> ElemTablLanguage { get; set; }
        
        public IDictionary<int, BibliogrLanguage> References { get; set; }
        
        
        public IList<SingTabl> SingTabl { get; set; }
        

        public async Task OnGetAsync(string systemUrl , string sing)
        {
            var headClue = _contextUtils.GetHeadClueBySystemUrl(systemUrl);

            var substanceElemTabl = _context.ElemTablLanguage
                .Include(m => m.ElemTabl)
                .Where(m => m.ElemTabl.HeadClue == headClue)
                .Where(m => m.LanguageId == this.GetLanguageId());

            
            if (!string.IsNullOrEmpty(sing))
            {
                substanceElemTabl = substanceElemTabl.Where(m => m.ElemTabl.SingCode == sing);
            }
            

            ElemTablLanguage = await substanceElemTabl.ToListAsync();

            
            SingTabl = await _context.SingTabl
                .Where(s => s.HeadClue == headClue)
                .ToListAsync();
            

            
            var bibliogrLanguage = await _context.BibliogrLanguage
                .Include(b => b.Bibliogr)
                .Where(b => b.LanguageId == this.GetLanguageId())
                .ToDictionaryAsync(b => b.BibliogrId, b => b);

            References = ElemTablLanguage
                .ToDictionary(h => h.ElemTablId, h =>
                    h.ElemTabl.Bknumber.HasValue ? bibliogrLanguage[(int) h.ElemTabl.Bknumber] : null
                );
            
        }
    }
}