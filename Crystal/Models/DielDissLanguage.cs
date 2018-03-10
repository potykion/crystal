using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class DielDissLanguage
    {
        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public decimal? FreqDiss { get; set; }
        public decimal? Temper3 { get; set; }
        public string TangName { get; set; }
        public decimal? TangentD { get; set; }
        public decimal? ErrDiss { get; set; }
        public string MethodY { get; set; }
        public int? Bknumber { get; set; }
        public string MethodY1 { get; set; }
        public int Id { get; set; }
        public int LanguageId { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
    }
}
