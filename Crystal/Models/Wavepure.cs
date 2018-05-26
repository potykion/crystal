using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class Wavepure
    {
        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        [Display(Name = "Leftwave")] public float? Leftwave { get; set; }
        [Display(Name = "Rightwave")] public float? Rightwave { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public HeadTablInvariant HeadClueNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
    }
}
