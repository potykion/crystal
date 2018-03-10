using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class MechTablLanguage
    {
        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public int? Bknumber { get; set; }
        public decimal? FreqCons { get; set; }
        public decimal? Temper { get; set; }
        public string ZnK { get; set; }
        public decimal? K { get; set; }
        public decimal? ErrK { get; set; }
        public string MethodK { get; set; }
        public string MethodK1 { get; set; }
        public int Id { get; set; }
        public int LanguageId { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
    }
}
