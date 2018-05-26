using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class GrafTablInvariant
    {
        public GrafTablInvariant()
        {
            GrafTablLanguage = new HashSet<GrafTablLanguage>();
        }

        public int HeadClue { get; set; }
        public float? NompClue { get; set; }
        public int Id { get; set; }

        public HeadTablInvariant HeadClueNavigation { get; set; }
        public ICollection<GrafTablLanguage> GrafTablLanguage { get; set; }
    }
}
