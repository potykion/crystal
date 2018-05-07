using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class HardTablInvariant
    {
        public HardTablInvariant()
        {
            HardTablLanguage = new HashSet<HardTablLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public decimal? Hard1 { get; set; }
        public decimal? Hard2 { get; set; }
        public decimal? ErrHard { get; set; }
        public decimal? Mohs { get; set; }
        public decimal? ErrMohs { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public HeadTablInvariant HeadClueNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<HardTablLanguage> HardTablLanguage { get; set; }
    }
}
