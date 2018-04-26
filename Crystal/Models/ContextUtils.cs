using System.Linq;


namespace Crystal.Models
{
    public class ContextUtils
    {
        private readonly CrystalContext _context;

        public ContextUtils(CrystalContext context)
        {
            _context = context;
        }

        public int GetHeadClueBySystemUrl(string systemUrl)
        {
            var headTablLanguage = _context.HeadTablInvariant.First(language => language.SystemUrl == systemUrl);
            return headTablLanguage.HeadClue;
        }
    }
}