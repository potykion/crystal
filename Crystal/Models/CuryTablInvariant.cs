using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class CuryTablInvariant
    {
        public CuryTablInvariant()
        {
            CuryTablLanguage = new HashSet<CuryTablLanguage>();
        }

        public int HeadClue { get; set; }
        [Display(Name = "CuryTemp")] public float? CuryTemp { get; set; }
        [Display(Name = "ErrCury")] public float? ErrCury { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public HeadTablInvariant HeadClueNavigation { get; set; }
        public ICollection<CuryTablLanguage> CuryTablLanguage { get; set; }
    }
}
