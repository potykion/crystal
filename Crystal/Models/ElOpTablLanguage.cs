using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class ElOpTablLanguage
    {
        public int Id { get; set; }
        public int ElOpTablId { get; set; }
        public int LanguageId { get; set; }
        [Display(Name = "MethodR")] public string MethodR { get; set; }
        [Display(Name = "ZnN1")] public string ZnN1 { get; set; }
        public string MethodR1 { get; set; }

        public ElOpTablInvariant ElOpTabl { get; set; }
    }
}
