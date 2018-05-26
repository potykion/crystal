using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class AcOpTablInvariant
    {
        public AcOpTablInvariant()
        {
            AcOpTablLanguage = new HashSet<AcOpTablLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        [Display(Name = "Nzv")] public string Nzv { get; set; }
        [Display(Name = "WaveLeng")] public float? WaveLeng { get; set; }
        [Display(Name = "M1")] public float? M1 { get; set; }
        [Display(Name = "M2")] public float? M2 { get; set; }
        [Display(Name = "M3")] public float? M3 { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public HeadTablInvariant HeadClueNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<AcOpTablLanguage> AcOpTablLanguage { get; set; }
    }
}
