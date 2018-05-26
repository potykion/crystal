using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class DielectrInvariant
    {
        public DielectrInvariant()
        {
            DielectrLanguage = new HashSet<DielectrLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        [Display(Name = "Constant")] public string Constant { get; set; }
        [Display(Name = "FreqDiel")] public float? FreqDiel { get; set; }
        [Display(Name = "Temper_2")] public float? Temper_2 { get; set; }
        [Display(Name = "Diel")] public float? Diel { get; set; }
        [Display(Name = "ErrY")] public float? ErrY { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<DielectrLanguage> DielectrLanguage { get; set; }
    }
}
