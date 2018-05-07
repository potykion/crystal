using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class PlavTablLanguage
    {
        public int Id { get; set; }
        public int PlavTablId { get; set; }
        public int LanguageId { get; set; }
        public string PlavType { get; set; }

        public PlavTablInvariant PlavTabl { get; set; }
    }
}
