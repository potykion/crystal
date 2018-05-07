using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class ElOpTablInvariant
    {
        public ElOpTablInvariant()
        {
            ElOpTablLanguage = new HashSet<ElOpTablLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public decimal? WvLeng { get; set; }
        public decimal? R { get; set; }
        public decimal? ErrR { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<ElOpTablLanguage> ElOpTablLanguage { get; set; }
    }
}
