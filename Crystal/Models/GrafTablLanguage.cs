using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class GrafTablLanguage
    {
        public int HeadClue { get; set; }
        public decimal? NompClue { get; set; }
        public string NameGraf { get; set; }
        public string Signatur { get; set; }
        public int Id { get; set; }
        public int LanguageId { get; set; }

        public HeadTablInvariant HeadClueNavigation { get; set; }
    }
}
