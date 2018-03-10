using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class PzElTablInvariant
    {
        public PzElTablInvariant()
        {
            PzElTablLanguage = new HashSet<PzElTablLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public decimal? FreqPzEl { get; set; }
        public string ConstD { get; set; }
        public decimal? D { get; set; }
        public decimal? ErrD { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<PzElTablLanguage> PzElTablLanguage { get; set; }
    }
}
