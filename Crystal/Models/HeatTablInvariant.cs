using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class HeatTablInvariant
    {
        public HeatTablInvariant()
        {
            HeatTablLanguage = new HashSet<HeatTablLanguage>();
        }

        public int HeadClue { get; set; }
        [Display(Name = "Temperat")] public float? Temperat { get; set; }
        [Display(Name = "ZnC")] public string ZnC { get; set; }
        [Display(Name = "C")] public float? C { get; set; }
        [Display(Name = "ErrC")] public float? ErrC { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public HeadTablInvariant HeadClueNavigation { get; set; }
        public ICollection<HeatTablLanguage> HeatTablLanguage { get; set; }
    }
}