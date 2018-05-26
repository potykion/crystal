using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class HeatExpnInvariant
    {
        public HeatExpnInvariant()
        {
            HeatExpnLanguage = new HashSet<HeatExpnLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public int DataType { get; set; }
        [Display(Name = "Temper_1")] public float? Temper_1 { get; set; }
        [Display(Name = "Temper_2")] public float? Temper_2 { get; set; }
        [Display(Name = "S11")] public float? S11 { get; set; }
        [Display(Name = "ErrHExp")] public float? ErrHExp { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<HeatExpnLanguage> HeatExpnLanguage { get; set; }
    }
}
