using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class DecrTablInvariant
    {
        public DecrTablInvariant()
        {
            DecrTablLanguage = new HashSet<DecrTablLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public decimal? WaveSpeed { get; set; }
        public decimal? Decrement { get; set; }
        public decimal? DecrFreq { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public HeadTablInvariant HeadClueNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<DecrTablLanguage> DecrTablLanguage { get; set; }
    }
}
