using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class MechTablLanguage
    {
        public int Id { get; set; }
        public int MechTablId { get; set; }
        public int LanguageId { get; set; }
        [Display(Name = "MethodK")] public string MethodK { get; set; }
        [Display(Name = "ZnK")] public string ZnK { get; set; }
        public string MethodK1 { get; set; }

        public MechTablInvariant MechTabl { get; set; }
    }
}
