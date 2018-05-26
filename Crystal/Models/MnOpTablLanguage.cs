using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class MnOpTablLanguage
    {
        public int Id { get; set; }
        public int MnOpTablId { get; set; }
        public int LanguageId { get; set; }
        [Display(Name = "MethodK")] public string MethodK { get; set; }
        public string MethodK1 { get; set; }

        public MnOpTablInvariant MnOpTabl { get; set; }
    }
}
