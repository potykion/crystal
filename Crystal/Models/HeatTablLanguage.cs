using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class HeatTablLanguage
    {
        public int Id { get; set; }
        public int HeatTablId { get; set; }
        public int LanguageId { get; set; }
        [Display(Name = "MethodC")] public string MethodC { get; set; }
        public string MethodC1 { get; set; }

        public HeatTablInvariant HeatTabl { get; set; }
    }
}