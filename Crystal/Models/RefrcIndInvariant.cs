using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class RefrcIndInvariant
    {
        public RefrcIndInvariant()
        {
            RefrcIndLanguage = new HashSet<RefrcIndLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public decimal? Temper { get; set; }
        public decimal? WaveLeng { get; set; }
        public string NazbIndx { get; set; }
        public decimal? ZnachInd { get; set; }
        public decimal? ErrIndex { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<RefrcIndLanguage> RefrcIndLanguage { get; set; }
    }
}
