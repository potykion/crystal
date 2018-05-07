using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class RefrTablLanguage
    {
        public int HeadClue { get; set; }
        public string Referat { get; set; }
        public int LanguageId { get; set; }
        public int Id { get; set; }

        public HeadTablInvariant HeadClueNavigation { get; set; }
    }
}
