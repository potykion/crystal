using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class CuryTablLanguage
    {
        public int HeadClue { get; set; }
        public decimal? CuryTemp { get; set; }
        public decimal? ErrCury { get; set; }
        public string Oboztran { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }
        public int LanguageId { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public HeadTablInvariant HeadClueNavigation { get; set; }
    }
}
