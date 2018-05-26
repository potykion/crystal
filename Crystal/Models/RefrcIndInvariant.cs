using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class RefrcIndInvariant
    {
        public RefrcIndInvariant()
        {
            RefrcIndLanguage = new HashSet<RefrcIndLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        [Display(Name = "Temper")] public float? Temper { get; set; }
        [Display(Name = "WaveLeng")] public float? WaveLeng { get; set; }
        [Display(Name = "NazbIndx")] public string NazbIndx { get; set; }
        [Display(Name = "ZnachInd")] public float? ZnachInd { get; set; }
        [Display(Name = "ErrIndex")] public float? ErrIndex { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<RefrcIndLanguage> RefrcIndLanguage { get; set; }
    }
}
