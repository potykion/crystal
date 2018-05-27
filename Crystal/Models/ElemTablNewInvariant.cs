using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class ElemTablNewInvariant
    {
        public ElemTablNewInvariant()
        {
            ElemTablNewLanguage = new HashSet<ElemTablNewLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public double? A { get; set; }
        public double? Aerr { get; set; }
        public double? B { get; set; }
        public double? Berr { get; set; }
        public double? C { get; set; }
        public double? Cerr { get; set; }
        [Display(Name = "Alpha")] public double? Alpha { get; set; }
        public double? AlphaErr { get; set; }
        [Display(Name = "Beta")] public double? Beta { get; set; }
        public double? BetaErr { get; set; }
        [Display(Name = "Gamma")] public double? Gamma { get; set; }
        public double? GammaErr { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<ElemTablNewLanguage> ElemTablNewLanguage { get; set; }
    }
}