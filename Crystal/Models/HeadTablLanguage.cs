using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class HeadTablLanguage
    {
        public int Id { get; set; }
        public int HeadTablId { get; set; }
        public int LanguageId { get; set; }
        public string Expert { get; set; }

        public HeadTablInvariant HeadTabl { get; set; }
    }
}
