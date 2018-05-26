using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class SuspTablLanguage
    {
        public int Id { get; set; }
        public int SuspTablId { get; set; }
        public int LanguageId { get; set; }
        [Display(Name = "MethodS")] public string MethodS { get; set; }
        [Display(Name = "SuspName")] public string SuspName { get; set; }
        public string MethodS1 { get; set; }

        public SuspTablInvariant SuspTabl { get; set; }
    }
}
