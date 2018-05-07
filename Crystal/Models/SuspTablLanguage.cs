using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class SuspTablLanguage
    {
        public int Id { get; set; }
        public int SuspTablId { get; set; }
        public int LanguageId { get; set; }
        public string MethodS { get; set; }
        public string SuspName { get; set; }
        public string MethodS1 { get; set; }

        public SuspTablInvariant SuspTabl { get; set; }
    }
}
