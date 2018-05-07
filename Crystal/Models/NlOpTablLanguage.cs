using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class NlOpTablLanguage
    {
        public int Id { get; set; }
        public int NlOpTablId { get; set; }
        public int LanguageId { get; set; }
        public string MethodR { get; set; }
        public string ZnR { get; set; }
        public string MethodR1 { get; set; }

        public NlOpTablInvariant NlOpTabl { get; set; }
    }
}
