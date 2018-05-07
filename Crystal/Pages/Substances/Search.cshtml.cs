using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crystal.Models;
using Crystal.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Crystal.Pages.Substances
{
    public class SearchPageModel : PageModel
    {
        private readonly CrystalContext _context;

        public SearchPageModel(CrystalContext context)
        {
            _context = context;
        }

        public IList<HeadTablLanguage> HeadTabl { get; set; }


        public async Task OnGetAsync(string system)
        {
            if (string.IsNullOrEmpty(system))
            {
                HeadTabl = new List<HeadTablLanguage>();
            }
            else
            {
                HeadTabl = await _context.HeadTablLanguage
                    .Include(h => h.HeadTabl)
                    .Where(h => h.HeadTabl.System.Contains(system))
                    .Where(h => h.LanguageId == this.GetLanguageId())
                    .ToListAsync();
            }
        }
    }
}