using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crystal.Models;
using Crystal.Utils;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Crystal.Pages.Substances
{
    public class PropertiesIndex : PageModel
    {
        private readonly List<string> _availableProperties =
            new List<string> {"HeatTabl", "DensTabl"};

        private readonly CrystalContext _context;

        public PropertiesIndex(CrystalContext context)
        {
            _context = context;
        }

        public IList<PropertiesLanguage> PropertiesLanguage { get; set; }

        public async Task OnGetAsync()
        {
            PropertiesLanguage = await _context.PropertiesLanguage
                .Include(p => p.Properties)
                .Where(p => _availableProperties.Contains(p.Properties.TableName))
                .Where(p => p.LanguageId == Request.GetLanguageId())
                .ToListAsync();
        }
    }
}