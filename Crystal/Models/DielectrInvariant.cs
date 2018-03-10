using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class DielectrInvariant
    {
        public DielectrInvariant()
        {
            DielectrLanguage = new HashSet<DielectrLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public decimal? FreqDiel { get; set; }
        public decimal? Temper2 { get; set; }
        public string Constant { get; set; }
        public decimal? Diel { get; set; }
        public decimal? ErrY { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<DielectrLanguage> DielectrLanguage { get; set; }
    }
}
