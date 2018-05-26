using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class ModfTablLanguage
    {
        public int Id { get; set; }
        public int ModfTablId { get; set; }
        public int LanguageId { get; set; }
        [Display(Name = "SpaceGrp")] public string SpaceGrp { get; set; }

        public ModfTablInvariant ModfTabl { get; set; }
    }
}
