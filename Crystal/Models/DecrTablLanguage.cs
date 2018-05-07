using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class DecrTablLanguage
    {
        public int Id { get; set; }
        public int DecrTablId { get; set; }
        public int LanguageId { get; set; }
        public string Nzv { get; set; }
        public string Uzv { get; set; }
        public string WaveType { get; set; }

        public DecrTablInvariant DecrTabl { get; set; }
    }
}
