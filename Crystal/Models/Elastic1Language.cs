using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class Elastic1Language
    {
        public int Id { get; set; }
        public int Elastic1Id { get; set; }
        public int LanguageId { get; set; }
        public string MethodE { get; set; }
        public string ZnE { get; set; }
        public string MethodE1 { get; set; }

        public Elastic1Invariant Elastic1 { get; set; }
    }
}
