using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class DecrTablLanguage
    {
        public int Id { get; set; }
        public int DecrTablId { get; set; }
        public int LanguageId { get; set; }
        [Display(Name = "Nzv")] public string Nzv { get; set; }
        [Display(Name = "Uzv")] public string Uzv { get; set; }
        [Display(Name = "WaveType")] public string WaveType { get; set; }

        public DecrTablInvariant DecrTabl { get; set; }
    }
}
