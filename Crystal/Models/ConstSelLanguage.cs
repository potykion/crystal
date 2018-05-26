using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class ConstSelLanguage
    {
        public int Id { get; set; }
        public int ConstSelId { get; set; }
        public int LanguageId { get; set; }
        [Display(Name = "Measure")] public string Measure { get; set; }

        public ConstSelInvariant ConstSel { get; set; }
    }
}