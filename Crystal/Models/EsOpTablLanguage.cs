using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class EsOpTablLanguage
    {
        public int Id { get; set; }
        public int EsOpTablId { get; set; }
        public int LanguageId { get; set; }
        [Display(Name = "MethodP")] public string MethodP { get; set; }
        [Display(Name = "ZnP")] public string ZnP { get; set; }
        public string MethodP1 { get; set; }

        public EsOpTablInvariant EsOpTabl { get; set; }
    }
}
