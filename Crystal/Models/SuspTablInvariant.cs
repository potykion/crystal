using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class SuspTablInvariant
    {
        public SuspTablInvariant()
        {
            SuspTablLanguage = new HashSet<SuspTablLanguage>();
        }

        public int HeadClue { get; set; }
        [Display(Name = "Temper")] public float? Temper { get; set; }
        [Display(Name = "Suspense")] public float? Suspense { get; set; }
        [Display(Name = "ErrSusp")] public float? ErrSusp { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public HeadTablInvariant HeadClueNavigation { get; set; }
        public ICollection<SuspTablLanguage> SuspTablLanguage { get; set; }
    }
}
