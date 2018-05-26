using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class DielDissLanguage
    {
        public int Id { get; set; }
        public int DielDissId { get; set; }
        public int LanguageId { get; set; }
        [Display(Name = "MethodY")] public string MethodY { get; set; }
        [Display(Name = "TangName")] public string TangName { get; set; }
        public string MethodY1 { get; set; }

        public DielDissInvariant DielDiss { get; set; }
    }
}