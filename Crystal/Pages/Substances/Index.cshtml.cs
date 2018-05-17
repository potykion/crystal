using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crystal.Models;
using Crystal.Utils;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Crystal.Pages.Substances
{
    public class IndexModel : PageModel
    {
        private const int LangasitesId = 1000;
        private readonly CrystalContext _context;

        public IndexModel(CrystalContext context)
        {
            _context = context;
        }

        public IList<HeadTablLanguage> HeadTablClass0 { get; set; }
        public IList<HeadTablLanguage> HeadTablClass1 { get; set; }


        public async Task OnGetAsync()
        {
            var headTablLanguage = _context.HeadTablLanguage
                .Include(h => h.HeadTabl)
                .Where(h => h.LanguageId == this.GetLanguageId());

            HeadTablClass0 = await headTablLanguage
                .Where(headTabl => headTabl.HeadTabl.Class == 0)
                .OrderBy(headTabl => headTabl.HeadTabl.System)
                .ToListAsync();
            HeadTablClass1 = await headTablLanguage
                .Where(headTabl => headTabl.HeadTabl.Class == 1 && headTabl.HeadTablId != LangasitesId)
                .OrderBy(headTabl => headTabl.HeadTabl.System)
                .ToListAsync();
        }
    }
}