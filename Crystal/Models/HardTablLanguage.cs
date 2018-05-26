using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class HardTablLanguage
    {
        public int Id { get; set; }
        public int HardTablId { get; set; }
        public int LanguageId { get; set; }
        [Display(Name = "MethodH")] public string MethodH { get; set; }
        public string MethodH1 { get; set; }

        public HardTablInvariant HardTabl { get; set; }
    }
}
