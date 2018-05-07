using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class EsOpTablInvariant
    {
        public EsOpTablInvariant()
        {
            EsOpTablLanguage = new HashSet<EsOpTablLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public decimal? LengWave { get; set; }
        public decimal? P { get; set; }
        public decimal? ErrP { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<EsOpTablLanguage> EsOpTablLanguage { get; set; }
    }
}
