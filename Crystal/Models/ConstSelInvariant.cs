using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class ConstSelInvariant
    {
        public ConstSelInvariant()
        {
            ConstSelLanguage = new HashSet<ConstSelLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        [Display(Name = "Equation")] public string Equation { get; set; }
        [Display(Name = "NazvSel")] public string NazvSel { get; set; }
        [Display(Name = "ZnachSel")] public float? ZnachSel { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<ConstSelLanguage> ConstSelLanguage { get; set; }
    }
}