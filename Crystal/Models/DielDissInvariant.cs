using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class DielDissInvariant
    {
        public DielDissInvariant()
        {
            DielDissLanguage = new HashSet<DielDissLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        [Display(Name = "FreqDiss")] public float? FreqDiss { get; set; }
        [Display(Name = "Temper_3")] public float? Temper_3 { get; set; }
        [Display(Name = "TangentD")] public float? TangentD { get; set; }
        [Display(Name = "ErrDiss")] public float? ErrDiss { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<DielDissLanguage> DielDissLanguage { get; set; }
    }
}