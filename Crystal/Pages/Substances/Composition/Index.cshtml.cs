using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crystal.Models;
using Crystal.Utils;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Crystal.Pages.Substances.Composition
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

        public IList<SistTabl> SistTabl { get; set; }
        public IList<GrafTablLanguage> Images { get; set; }

        public async Task OnGetAsync(string systemUrl )
        {
            var headClue = _contextUtils.GetHeadClueBySystemUrl(systemUrl);

            var substanceSistTabl = _context.SistTabl
                .Where(m => m.HeadClue == headClue);



            SistTabl = await substanceSistTabl.ToListAsync();

            Images = await _context.GrafTablLanguage
                .Include(image => image.GrafTabl)
                .Where(image => image.LanguageId == this.GetLanguageId())
                .Where(image => image.GrafTabl.HeadClue == headClue)
                .Where(image => image.GrafTabl.NompClue == 4)
                .ToListAsync();


        }
    }
}