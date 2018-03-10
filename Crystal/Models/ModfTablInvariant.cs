using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class ModfTablInvariant
    {
        public ModfTablInvariant()
        {
            ModfTablLanguage = new HashSet<ModfTablLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public decimal? SuprTemp { get; set; }
        public decimal? Sp2 { get; set; }
        public decimal? ErrSupr { get; set; }
        public string PointGrp { get; set; }
        public decimal? Z { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<ModfTablLanguage> ModfTablLanguage { get; set; }
    }
}
