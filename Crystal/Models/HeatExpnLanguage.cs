using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class HeatExpnLanguage
    {
        public int Id { get; set; }
        public int HeatExpnId { get; set; }
        public int LanguageId { get; set; }
        [Display(Name = "MethodEx")] public string MethodEx { get; set; }
        [Display(Name = "Znak1")] public string Znak1 { get; set; }
        public string MethodEx1 { get; set; }

        public HeatExpnInvariant HeatExpn { get; set; }
    }
}