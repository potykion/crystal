using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class PlavTablLanguage
    {
        public int HeadClue { get; set; }
        public string PlavType { get; set; }
        public decimal? PlavTemp { get; set; }
        public decimal? ErrPlav { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }
        public int LanguageId { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public HeadTablInvariant HeadClueNavigation { get; set; }
    }
}
