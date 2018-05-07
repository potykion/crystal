using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class NlOpTablInvariant
    {
        public NlOpTablInvariant()
        {
            NlOpTablLanguage = new HashSet<NlOpTablLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public decimal? Lyambda { get; set; }
        public decimal? Rij { get; set; }
        public decimal? ErrRij { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<NlOpTablLanguage> NlOpTablLanguage { get; set; }
    }
}
