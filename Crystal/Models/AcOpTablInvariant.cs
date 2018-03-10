using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class AcOpTablInvariant
    {
        public AcOpTablInvariant()
        {
            AcOpTablLanguage = new HashSet<AcOpTablLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public decimal? WaveLeng { get; set; }
        public string Nzv { get; set; }
        public decimal? M1 { get; set; }
        public decimal? M2 { get; set; }
        public decimal? M3 { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public HeadTablInvariant HeadClueNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<AcOpTablLanguage> AcOpTablLanguage { get; set; }
    }
}
