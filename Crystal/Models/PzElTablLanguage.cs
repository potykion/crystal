using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class PzElTablLanguage
    {
        public int Id { get; set; }
        public int PzElTablId { get; set; }
        public int LanguageId { get; set; }
        public string MethodPz { get; set; }
        public string MethodPz1 { get; set; }

        public PzElTablInvariant PzElTabl { get; set; }
    }
}
