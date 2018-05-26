using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class EsOpTablInvariant
    {
        public EsOpTablInvariant()
        {
            EsOpTablLanguage = new HashSet<EsOpTablLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        [Display(Name = "LengWave")] public float? LengWave { get; set; }
        [Display(Name = "P")] public float? P { get; set; }
        [Display(Name = "ErrP")] public float? ErrP { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<EsOpTablLanguage> EsOpTablLanguage { get; set; }
    }
}
