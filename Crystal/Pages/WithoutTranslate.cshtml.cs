using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crystal.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Crystal
{
    public class WithoutTranslateModel : PageModel
    {
        private readonly CrystalContext _context;

        public WithoutTranslateModel(CrystalContext context)
        {
            _context = context;
        }

        public IList<HeadTablInvariant> HeadTablWithoutEnglish { get; set; }
        public IList<HeadTablInvariant> HeadTablWithoutRussian { get; set; }


        public async Task OnGetAsync()
        {
            var headTablLanguageRussian = _context.HeadTablLanguage
                .Where(hl => hl.LanguageId == 1)
                .Select(hl => hl.HeadTablId);

            var headTablLanguageEnglish = _context.HeadTablLanguage
                .Where(hl => hl.LanguageId == 2)
                .Select(hl => hl.HeadTablId);

            HeadTablWithoutEnglish = await _context.HeadTablInvariant
                .Where(h => headTablLanguageRussian.Contains(h.HeadClue))
                .Where(h => !headTablLanguageEnglish.Contains(h.HeadClue))
                .ToListAsync();

            HeadTablWithoutRussian = await _context.HeadTablInvariant
                .Where(h => !headTablLanguageRussian.Contains(h.HeadClue))
                .Where(h => headTablLanguageEnglish.Contains(h.HeadClue))
                .ToListAsync();
            
            
        }
    }
}