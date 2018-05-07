using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class ElOpTablLanguage
    {
        public int Id { get; set; }
        public int ElOpTablId { get; set; }
        public int LanguageId { get; set; }
        public string MethodR { get; set; }
        public string ZnN1 { get; set; }
        public string MethodR1 { get; set; }

        public ElOpTablInvariant ElOpTabl { get; set; }
    }
}
