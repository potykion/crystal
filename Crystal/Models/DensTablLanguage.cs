using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class DensTablLanguage
    {
        public int Id { get; set; }
        public int DensTablId { get; set; }
        public int LanguageId { get; set; }
        [Display(Name = "MethodD")] public string MethodD { get; set; }
        public string MethodD1 { get; set; }

        public DensTablInvariant DensTabl { get; set; }
    }
}
