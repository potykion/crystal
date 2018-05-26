using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class PzElTablInvariant
    {
        public PzElTablInvariant()
        {
            PzElTablLanguage = new HashSet<PzElTablLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        [Display(Name = "FreqPzEl")] public float? FreqPzEl { get; set; }
        [Display(Name = "ConstD")] public string ConstD { get; set; }
        [Display(Name = "D")] public float? D { get; set; }
        [Display(Name = "ErrD")] public float? ErrD { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<PzElTablLanguage> PzElTablLanguage { get; set; }
    }
}
