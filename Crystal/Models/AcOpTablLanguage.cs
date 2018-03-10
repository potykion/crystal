using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class AcOpTablLanguage
    {
        public int Id { get; set; }
        public int AcOpTablId { get; set; }
        public int LanguageId { get; set; }
        public string E { get; set; }
        public string Nsv { get; set; }
        public string Uzv { get; set; }

        public AcOpTablInvariant AcOpTabl { get; set; }
    }
}
