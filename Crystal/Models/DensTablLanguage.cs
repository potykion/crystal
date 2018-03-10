using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class DensTablLanguage
    {
        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public decimal? Density { get; set; }
        public decimal? ErrDens { get; set; }
        public string MethodD { get; set; }
        public int? Bknumber { get; set; }
        public string MethodD1 { get; set; }
        public int Id { get; set; }
        public int LanguageId { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public HeadTablInvariant HeadClueNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
    }
}
