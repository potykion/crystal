using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class DielectrLanguage
    {
        public int Id { get; set; }
        public int DielectrId { get; set; }
        public int LanguageId { get; set; }
        public string MethodY { get; set; }
        public string Znak { get; set; }
        public string MethodY1 { get; set; }

        public DielectrInvariant Dielectr { get; set; }
    }
}
