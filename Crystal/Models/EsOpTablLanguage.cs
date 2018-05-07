using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class EsOpTablLanguage
    {
        public int Id { get; set; }
        public int EsOpTablId { get; set; }
        public int LanguageId { get; set; }
        public string MethodP { get; set; }
        public string ZnP { get; set; }
        public string MethodP1 { get; set; }

        public EsOpTablInvariant EsOpTabl { get; set; }
    }
}
