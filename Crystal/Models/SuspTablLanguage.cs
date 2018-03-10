using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class SuspTablLanguage
    {
        public int HeadClue { get; set; }
        public decimal? Temper { get; set; }
        public string SuspName { get; set; }
        public decimal Suspense { get; set; }
        public decimal? ErrSusp { get; set; }
        public string MethodS { get; set; }
        public int? Bknumber { get; set; }
        public string MethodS1 { get; set; }
        public int Id { get; set; }
        public int LanguageId { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public HeadTablInvariant HeadClueNavigation { get; set; }
    }
}
