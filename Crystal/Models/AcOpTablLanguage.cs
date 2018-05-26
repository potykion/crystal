using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class AcOpTablLanguage
    {
        public int Id { get; set; }
        public int AcOpTablId { get; set; }
        public int LanguageId { get; set; }
        [Display(Name = "E")] public string E { get; set; }
        [Display(Name = "Nsv")] public string Nsv { get; set; }
        [Display(Name = "Uzv")] public string Uzv { get; set; }

        public AcOpTablInvariant AcOpTabl { get; set; }
    }
}
