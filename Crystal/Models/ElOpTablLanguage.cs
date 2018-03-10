using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class ElOpTablLanguage
    {
        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public decimal? WvLeng { get; set; }
        public string ZnN1 { get; set; }
        public decimal? R { get; set; }
        public decimal? ErrR { get; set; }
        public string MethodR { get; set; }
        public int? Bknumber { get; set; }
        public string MethodR1 { get; set; }
        public int Id { get; set; }
        public int LanguageId { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
    }
}
