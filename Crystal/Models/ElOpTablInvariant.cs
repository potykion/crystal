using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class ElOpTablInvariant
    {
        public ElOpTablInvariant()
        {
            ElOpTablLanguage = new HashSet<ElOpTablLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        [Display(Name = "WvLeng")] public float? WvLeng { get; set; }
        [Display(Name = "R")] public float? R { get; set; }
        [Display(Name = "ErrR")] public float? ErrR { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<ElOpTablLanguage> ElOpTablLanguage { get; set; }
    }
}
