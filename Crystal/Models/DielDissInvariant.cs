using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class DielDissInvariant
    {
        public DielDissInvariant()
        {
            DielDissLanguage = new HashSet<DielDissLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public decimal? FreqDiss { get; set; }
        public decimal? Temper_3 { get; set; }
        public decimal? TangentD { get; set; }
        public decimal? ErrDiss { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<DielDissLanguage> DielDissLanguage { get; set; }
    }
}
