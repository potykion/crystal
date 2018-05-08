using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crystal.Models;
using Crystal.Utils;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Crystal.Pages.Substances
{
    public class SubstanceInfoModel : PageModel
    {
        private readonly List<string> _availableProperties =
            new List<string>
            {
                "HeatTabl",
                "DensTabl",
                "HardTabl",
                "SuspTabl",
                "PlavTabl",
                "CuryTabl",
                "ModfTabl",
                "ElemTabl",
                "HeatExpn0",
                "HeatExpn1",
                "Dielectr",
                "DielDiss",
                "PzElTabl",
                "MechTabl",
                "Elastic1",
                "RefrcInd",
                "ConstSel",
                "ElOpTabl",
                "NlOpTabl",
                "EsOpTabl",
                "DecrTabl",
                "AcOpTabl",
            };

        private readonly CrystalContext _context;

        public SubstanceInfoModel(CrystalContext context)
        {
            _context = context;
        }

        public HeadTablLanguage HeadTablLanguage { get; set; }
        public IList<PropertiesLanguage> PropertiesLanguage { get; set; }

        public async Task OnGetAsync(string systemUrl)
        {
            HeadTablLanguage = await _context.HeadTablLanguage
                .Include(headTabl => headTabl.HeadTabl)
                .Where(headTabl => headTabl.HeadTabl.SystemUrl == systemUrl)
                .FirstAsync();

            PropertiesLanguage = await _context.PropertiesLanguage
                .Include(p => p.Properties)
                .Where(p => _availableProperties.Contains(p.Properties.TableName))
                .Where(p => p.LanguageId == this.GetLanguageId())
                .ToListAsync();
        }
    }
}