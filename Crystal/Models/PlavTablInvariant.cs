using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class PlavTablInvariant
    {
        public PlavTablInvariant()
        {
            PlavTablLanguage = new HashSet<PlavTablLanguage>();
        }

        public int HeadClue { get; set; }
        [Display(Name = "PlavTemp")] public float? PlavTemp { get; set; }
        [Display(Name = "ErrPlav")] public float? ErrPlav { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public HeadTablInvariant HeadClueNavigation { get; set; }
        public ICollection<PlavTablLanguage> PlavTablLanguage { get; set; }
    }
}
