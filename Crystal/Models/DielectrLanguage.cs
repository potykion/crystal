using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class DielectrLanguage
    {
        public int Id { get; set; }
        public int DielectrId { get; set; }
        public int LanguageId { get; set; }
        [Display(Name = "MethodY")] public string MethodY { get; set; }
        [Display(Name = "Znak")] public string Znak { get; set; }
        public string MethodY1 { get; set; }

        public DielectrInvariant Dielectr { get; set; }
    }
}
