using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class EsOpTablLanguage
    {
        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public decimal? LengWave { get; set; }
        public string ZnP { get; set; }
        public decimal? P { get; set; }
        public decimal? ErrP { get; set; }
        public string MethodP { get; set; }
        public int? Bknumber { get; set; }
        public string MethodP1 { get; set; }
        public int Id { get; set; }
        public int LanguageId { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
    }
}
