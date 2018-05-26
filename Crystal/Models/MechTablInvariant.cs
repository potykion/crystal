using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class MechTablInvariant
    {
        public MechTablInvariant()
        {
            MechTablLanguage = new HashSet<MechTablLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public int? Bknumber { get; set; }
        [Display(Name = "FreqCons")] public float? FreqCons { get; set; }
        [Display(Name = "Temper")] public float? Temper { get; set; }
        [Display(Name = "K")] public float? K { get; set; }
        [Display(Name = "ErrK")] public float? ErrK { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<MechTablLanguage> MechTablLanguage { get; set; }
    }
}
