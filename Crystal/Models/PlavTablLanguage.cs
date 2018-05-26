using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class PlavTablLanguage
    {
        public int Id { get; set; }
        public int PlavTablId { get; set; }
        public int LanguageId { get; set; }
        [Display(Name = "PlavType")] public string PlavType { get; set; }

        public PlavTablInvariant PlavTabl { get; set; }
    }
}
