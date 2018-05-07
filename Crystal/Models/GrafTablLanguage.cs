using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class GrafTablLanguage
    {
        public int Id { get; set; }
        public int GrafTablId { get; set; }
        public int LanguageId { get; set; }
        public string NameGraf { get; set; }
        public string Signatur { get; set; }
        public string Signatur1 { get; set; }

        public GrafTablInvariant GrafTabl { get; set; }
    }
}
