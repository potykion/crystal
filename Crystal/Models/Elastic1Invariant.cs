using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class Elastic1Invariant
    {
        public Elastic1Invariant()
        {
            Elastic1Language = new HashSet<Elastic1Language>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        [Display(Name = "TemperEl")] public float? TemperEl { get; set; }
        [Display(Name = "CondClu1")] public string CondClu1 { get; set; }
        [Display(Name = "E1")] public float? E1 { get; set; }
        [Display(Name = "ErrE")] public float? ErrE { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<Elastic1Language> Elastic1Language { get; set; }
    }
}
