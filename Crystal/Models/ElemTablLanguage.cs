using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class ElemTablLanguage
    {
        public int Id { get; set; }
        public int ElemTablId { get; set; }
        public int LanguageId { get; set; }
        public string MethodP { get; set; }
        public string Nazbparam { get; set; }
        public string MethodP1 { get; set; }

        public ElemTablInvariant ElemTabl { get; set; }
    }
}
