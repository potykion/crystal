using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class CuryTablLanguage
    {
        public int Id { get; set; }
        public int CuryTablId { get; set; }
        public int LanguageId { get; set; }
        [Display(Name = "Oboztran")] public string Oboztran { get; set; }

        public CuryTablInvariant CuryTabl { get; set; }
    }
}
