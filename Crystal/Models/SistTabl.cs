using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class SistTabl
    {
        public int HeadClue { get; set; }
        public string ElemNumb { get; set; }
        public decimal? MinValue { get; set; }
        public decimal? MaxValue { get; set; }
        public int Id { get; set; }

        public HeadTablInvariant HeadClueNavigation { get; set; }
    }
}
