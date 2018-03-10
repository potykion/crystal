using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class MnOpTablInvariant
    {
        public MnOpTablInvariant()
        {
            MnOpTablLanguage = new HashSet<MnOpTablLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public decimal? Lyambda { get; set; }
        public decimal? Nw { get; set; }
        public decimal? N2w { get; set; }
        public string Znakcon { get; set; }
        public decimal? K { get; set; }
        public decimal? ErrKj { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<MnOpTablLanguage> MnOpTablLanguage { get; set; }
    }
}
