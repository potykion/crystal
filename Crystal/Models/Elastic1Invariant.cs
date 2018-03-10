using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class Elastic1Invariant
    {
        public Elastic1Invariant()
        {
            Elastic1Language = new HashSet<Elastic1Language>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public decimal? TemperEl { get; set; }
        public string CondClu1 { get; set; }
        public decimal? E1 { get; set; }
        public decimal? ErrE { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<Elastic1Language> Elastic1Language { get; set; }
    }
}
