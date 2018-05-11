using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class HeatExpnInvariant
    {
        public HeatExpnInvariant()
        {
            HeatExpnLanguage = new HashSet<HeatExpnLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public int DataType { get; set; }
        public decimal? Temper_1 { get; set; }
        public decimal? Temper_2 { get; set; }
        public decimal? S11 { get; set; }
        public decimal? ErrHExp { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<HeatExpnLanguage> HeatExpnLanguage { get; set; }
    }
}
