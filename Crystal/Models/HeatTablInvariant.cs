using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class HeatTablInvariant
    {
        public HeatTablInvariant()
        {
            HeatTablLanguage = new HashSet<HeatTablLanguage>();
        }

        public int HeadClue { get; set; }
        public decimal? Temperat { get; set; }
        public string ZnC { get; set; }
        public decimal? C { get; set; }
        public decimal? ErrC { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public HeadTablInvariant HeadClueNavigation { get; set; }
        public ICollection<HeatTablLanguage> HeatTablLanguage { get; set; }
    }
}
