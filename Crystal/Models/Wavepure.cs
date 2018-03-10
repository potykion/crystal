using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class Wavepure
    {
        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public decimal? Leftwave { get; set; }
        public decimal? Rightwave { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public HeadTablInvariant HeadClueNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
    }
}
