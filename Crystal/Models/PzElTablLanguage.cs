using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class PzElTablLanguage
    {
        public int Id { get; set; }
        public int PzElTablId { get; set; }
        public int LanguageId { get; set; }
        [Display(Name = "MethodPz")] public string MethodPz { get; set; }
        public string MethodPz1 { get; set; }

        public PzElTablInvariant PzElTabl { get; set; }
    }
}