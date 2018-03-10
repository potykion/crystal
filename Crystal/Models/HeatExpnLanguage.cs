using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class HeatExpnLanguage
    {
        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public int DataType { get; set; }
        public decimal? Temper1 { get; set; }
        public decimal? Temper2 { get; set; }
        public string Znak1 { get; set; }
        public decimal? S11 { get; set; }
        public decimal? ErrHexp { get; set; }
        public string MethodEx { get; set; }
        public int? Bknumber { get; set; }
        public string MethodEx1 { get; set; }
        public int Id { get; set; }
        public int LanguageId { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
    }
}
