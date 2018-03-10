using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class DecrTablLanguage
    {
        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public string Nzv { get; set; }
        public string Uzv { get; set; }
        public string WaveType { get; set; }
        public decimal? WaveSpeed { get; set; }
        public decimal? Decrement { get; set; }
        public decimal? DecrFreq { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }
        public int LanguageId { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public HeadTablInvariant HeadClueNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
    }
}
