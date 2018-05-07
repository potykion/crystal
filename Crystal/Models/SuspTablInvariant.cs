using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class SuspTablInvariant
    {
        public SuspTablInvariant()
        {
            SuspTablLanguage = new HashSet<SuspTablLanguage>();
        }

        public int HeadClue { get; set; }
        public decimal? Temper { get; set; }
        public decimal Suspense { get; set; }
        public decimal? ErrSusp { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public HeadTablInvariant HeadClueNavigation { get; set; }
        public ICollection<SuspTablLanguage> SuspTablLanguage { get; set; }
    }
}
