using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class HardTablInvariant
    {
        public HardTablInvariant()
        {
            HardTablLanguage = new HashSet<HardTablLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        [Display(Name = "Hard1")] public float? Hard1 { get; set; }
        [Display(Name = "Hard2")] public float? Hard2 { get; set; }
        [Display(Name = "ErrHard")] public float? ErrHard { get; set; }
        [Display(Name = "Mohs")] public float? Mohs { get; set; }
        [Display(Name = "ErrMohs")] public float? ErrMohs { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public HeadTablInvariant HeadClueNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<HardTablLanguage> HardTablLanguage { get; set; }
    }
}
