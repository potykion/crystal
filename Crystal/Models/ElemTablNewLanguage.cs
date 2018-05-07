using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class ElemTablNewLanguage
    {
        public int Id { get; set; }
        public int ElemTablNewId { get; set; }
        public int LanguageId { get; set; }
        public string MethodP { get; set; }
        public string MethodP1 { get; set; }

        public ElemTablNewInvariant ElemTablNew { get; set; }
    }
}
