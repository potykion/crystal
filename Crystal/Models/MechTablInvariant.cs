using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class MechTablInvariant
    {
        public MechTablInvariant()
        {
            MechTablLanguage = new HashSet<MechTablLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public int? Bknumber { get; set; }
        public decimal? FreqCons { get; set; }
        public decimal? Temper { get; set; }
        public decimal? K { get; set; }
        public decimal? ErrK { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<MechTablLanguage> MechTablLanguage { get; set; }
    }
}
