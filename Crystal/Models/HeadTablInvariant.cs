using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class HeadTablInvariant
    {
        public HeadTablInvariant()
        {
            HeadTablLanguage = new HashSet<HeadTablLanguage>();
        }

        public int HeadClue { get; set; }
        public string Help { get; set; }
        public int Class { get; set; }

        public ICollection<HeadTablLanguage> HeadTablLanguage { get; set; }
    }
}
