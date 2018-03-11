using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using Crystal.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Crystal.Pages.DensTabl
{
    public class IndexModel : PageModel
    {
        private readonly CrystalContext _context;

        public IndexModel(CrystalContext context)
        {
            _context = context;
        }

        public IList<DensTablLanguage> DensTablLanguage { get; set; }
        public IList<SingTabl> SingTabl { get; set; }

        public async Task OnGetAsync(int headClue, int? singClue)
        {
            var densTablValues = _context.DensTablLanguage
                .Where(d => d.HeadClue == headClue);

            SingTabl = await _context.SingTabl
                .Where(s => s.HeadClue == headClue)
                .ToListAsync();


            if (singClue.HasValue)
            {
                densTablValues = densTablValues.Where(d => d.SingTabl.SingClue == singClue);
            }

            DensTablLanguage = await densTablValues.ToListAsync();
        }
    }
}