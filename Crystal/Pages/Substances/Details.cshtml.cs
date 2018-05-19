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
        public Dictionary<string, bool> AvailableProperties { get; } =
            new Dictionary<string, bool>();

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

            AvailableProperties["HeatTabl"] = await _context.HeatTablInvariant
                                                   .Where(m => m.HeadClue == HeadTablLanguage.HeadTablId)
                                                   .FirstOrDefaultAsync() != null;
            AvailableProperties["DensTabl"] = await _context.DensTablInvariant
                                                   .Where(m => m.HeadClue == HeadTablLanguage.HeadTablId)
                                                   .FirstOrDefaultAsync() != null;
            AvailableProperties["HardTabl"] = await _context.HardTablInvariant
                                                   .Where(m => m.HeadClue == HeadTablLanguage.HeadTablId)
                                                   .FirstOrDefaultAsync() != null;
            AvailableProperties["SuspTabl"] = await _context.SuspTablInvariant
                                                   .Where(m => m.HeadClue == HeadTablLanguage.HeadTablId)
                                                   .FirstOrDefaultAsync() != null;
            AvailableProperties["PlavTabl"] = await _context.PlavTablInvariant
                                                   .Where(m => m.HeadClue == HeadTablLanguage.HeadTablId)
                                                   .FirstOrDefaultAsync() != null;
            AvailableProperties["CuryTabl"] = await _context.CuryTablInvariant
                                                   .Where(m => m.HeadClue == HeadTablLanguage.HeadTablId)
                                                   .FirstOrDefaultAsync() != null;
            AvailableProperties["ModfTabl"] = await _context.ModfTablInvariant
                                                   .Where(m => m.HeadClue == HeadTablLanguage.HeadTablId)
                                                   .FirstOrDefaultAsync() != null;
            AvailableProperties["ElemTabl"] = await _context.ElemTablInvariant
                                                   .Where(m => m.HeadClue == HeadTablLanguage.HeadTablId)
                                                   .FirstOrDefaultAsync() != null;
            AvailableProperties["HeatExpn0"] = await _context.HeatExpnInvariant
                                                    .Where(m => m.DataType == 0)
                                                    .Where(m => m.HeadClue == HeadTablLanguage.HeadTablId)
                                                    .FirstOrDefaultAsync() != null;
            AvailableProperties["HeatExpn1"] = await _context.HeatExpnInvariant
                                                    .Where(m => m.DataType == 1)
                                                    .Where(m => m.HeadClue == HeadTablLanguage.HeadTablId)
                                                    .FirstOrDefaultAsync() != null;
            AvailableProperties["Dielectr"] = await _context.DielectrInvariant
                                                   .Where(m => m.HeadClue == HeadTablLanguage.HeadTablId)
                                                   .FirstOrDefaultAsync() != null;
            AvailableProperties["DielDiss"] = await _context.DielDissInvariant
                                                   .Where(m => m.HeadClue == HeadTablLanguage.HeadTablId)
                                                   .FirstOrDefaultAsync() != null;
            AvailableProperties["PzElTabl"] = await _context.PzElTablInvariant
                                                   .Where(m => m.HeadClue == HeadTablLanguage.HeadTablId)
                                                   .FirstOrDefaultAsync() != null;
            AvailableProperties["MechTabl"] = await _context.MechTablInvariant
                                                   .Where(m => m.HeadClue == HeadTablLanguage.HeadTablId)
                                                   .FirstOrDefaultAsync() != null;
            AvailableProperties["Elastic1"] = await _context.Elastic1Invariant
                                                   .Where(m => m.HeadClue == HeadTablLanguage.HeadTablId)
                                                   .FirstOrDefaultAsync() != null;
            AvailableProperties["RefrcInd"] = await _context.RefrcIndInvariant
                                                   .Where(m => m.HeadClue == HeadTablLanguage.HeadTablId)
                                                   .FirstOrDefaultAsync() != null;
            AvailableProperties["ConstSel"] = await _context.ConstSelInvariant
                                                   .Where(m => m.HeadClue == HeadTablLanguage.HeadTablId)
                                                   .FirstOrDefaultAsync() != null;
            AvailableProperties["ElOpTabl"] = await _context.ElOpTablInvariant
                                                   .Where(m => m.HeadClue == HeadTablLanguage.HeadTablId)
                                                   .FirstOrDefaultAsync() != null;
            AvailableProperties["NlOpTabl"] = await _context.NlOpTablInvariant
                                                   .Where(m => m.HeadClue == HeadTablLanguage.HeadTablId)
                                                   .FirstOrDefaultAsync() != null;
            AvailableProperties["EsOpTabl"] = await _context.EsOpTablInvariant
                                                   .Where(m => m.HeadClue == HeadTablLanguage.HeadTablId)
                                                   .FirstOrDefaultAsync() != null;
            AvailableProperties["DecrTabl"] = await _context.DecrTablInvariant
                                                   .Where(m => m.HeadClue == HeadTablLanguage.HeadTablId)
                                                   .FirstOrDefaultAsync() != null;
            AvailableProperties["AcOpTabl"] = await _context.AcOpTablInvariant
                                                   .Where(m => m.HeadClue == HeadTablLanguage.HeadTablId)
                                                   .FirstOrDefaultAsync() != null;
            AvailableProperties["Wavepure"] = await _context.Wavepure
                                                   .Where(m => m.HeadClue == HeadTablLanguage.HeadTablId)
                                                   .FirstOrDefaultAsync() != null;
            AvailableProperties["SistTabl"] = await _context.SistTabl
                                                   .Where(m => m.HeadClue == HeadTablLanguage.HeadTablId)
                                                   .FirstOrDefaultAsync() != null;

            PropertiesLanguage = await _context.PropertiesLanguage
                .Include(p => p.Properties)
                .Where(p => AvailableProperties.Keys.Contains(p.Properties.TableName))
                .Where(p => p.LanguageId == this.GetLanguageId())
                .ToListAsync();
        }
    }
}