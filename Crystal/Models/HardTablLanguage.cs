using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class HardTablLanguage
    {
        public int Id { get; set; }
        public int HardTablId { get; set; }
        public int LanguageId { get; set; }
        public string MethodH { get; set; }
        public string MethodH1 { get; set; }

        public HardTablInvariant HardTabl { get; set; }
    }
}
