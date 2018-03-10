using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class HeatTablLanguage
    {
        public int Id { get; set; }
        public int HeatTablId { get; set; }
        public int LanguageId { get; set; }
        public string MethodC { get; set; }
        public string MethodC1 { get; set; }

        public HeatTablInvariant HeatTabl { get; set; }
    }
}
