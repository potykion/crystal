using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class HeatExpnLanguage
    {
        public int Id { get; set; }
        public int HeatExpnId { get; set; }
        public int LanguageId { get; set; }
        public string MethodEx { get; set; }
        public string Znak1 { get; set; }
        public string MethodEx1 { get; set; }

        public HeatExpnInvariant HeatExpn { get; set; }
    }
}
