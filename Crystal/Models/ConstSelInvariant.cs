using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class ConstSelInvariant
    {
        public ConstSelInvariant()
        {
            ConstSelLanguage = new HashSet<ConstSelLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public string Equation { get; set; }
        public string NazvSel { get; set; }
        public decimal? ZnachSel { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<ConstSelLanguage> ConstSelLanguage { get; set; }
    }
}
