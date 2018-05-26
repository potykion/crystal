using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class ModfTablInvariant
    {
        public ModfTablInvariant()
        {
            ModfTablLanguage = new HashSet<ModfTablLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        [Display(Name = "PointGrp")] public string PointGrp { get; set; }
        [Display(Name = "SuprTemp")] public float? SuprTemp { get; set; }
        [Display(Name = "SP2")] public float? SP2 { get; set; }
        [Display(Name = "ErrSupr")] public float? ErrSupr { get; set; }
        [Display(Name = "Z")] public float? Z { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<ModfTablLanguage> ModfTablLanguage { get; set; }
    }
}
