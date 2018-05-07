using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class CuryTablInvariant
    {
        public CuryTablInvariant()
        {
            CuryTablLanguage = new HashSet<CuryTablLanguage>();
        }

        public int HeadClue { get; set; }
        public decimal? CuryTemp { get; set; }
        public decimal? ErrCury { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public HeadTablInvariant HeadClueNavigation { get; set; }
        public ICollection<CuryTablLanguage> CuryTablLanguage { get; set; }
    }
}
