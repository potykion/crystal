using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class NlOpTablLanguage
    {
        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public decimal? Lyambda { get; set; }
        public string ZnR { get; set; }
        public decimal? Rij { get; set; }
        public decimal? ErrRij { get; set; }
        public string MethodR { get; set; }
        public int? Bknumber { get; set; }
        public string MethodR1 { get; set; }
        public int Id { get; set; }
        public int LanguageId { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
    }
}
