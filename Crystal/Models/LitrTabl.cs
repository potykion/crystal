using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class LitrTabl
    {
        public int HeadClue { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public HeadTablInvariant HeadClueNavigation { get; set; }
    }
}
