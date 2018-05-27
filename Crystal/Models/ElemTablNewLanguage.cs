using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class ElemTablNewLanguage
    {
        public int Id { get; set; }
        public int ElemTablNewId { get; set; }
        public int LanguageId { get; set; }
        [Display(Name="MethodP")] public string MethodP { get; set; }
        public string MethodP1 { get; set; }

        public ElemTablNewInvariant ElemTablNew { get; set; }
    }
}
