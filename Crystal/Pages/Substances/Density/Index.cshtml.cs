using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crystal.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Crystal.Pages.Substances.Density
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

        public IList<DensTablLanguage> DensTablLanguage { get; set; }
        public IList<SingTabl> SingTabl { get; set; }

        public async Task OnGetAsync(string systemUrl, int? singClue)
        {
            var headClue = _contextUtils.GetHeadClueBySystemUrl(systemUrl);

            var densTablValues = _context.DensTablLanguage
                .Include(d => d.DensTabl)
                .Include(d => d.DensTabl.SingTabl)
                .Where(d => d.DensTabl.HeadClue == headClue);

            SingTabl = await _context.SingTabl
                .Where(s => s.HeadClue == headClue)
                .ToListAsync();


            if (singClue.HasValue)
            {
                densTablValues = densTablValues.Where(d => d.DensTabl.SingTabl.SingClue == singClue);
            }

            DensTablLanguage = await densTablValues.ToListAsync();
        }
    }
}