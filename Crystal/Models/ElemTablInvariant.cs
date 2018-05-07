using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class ElemTablInvariant
    {
        public ElemTablInvariant()
        {
            ElemTablLanguage = new HashSet<ElemTablLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public double? Znparam { get; set; }
        public double? Errparam { get; set; }
        public string NazvAngl { get; set; }
        public double? ZnAngle { get; set; }
        public double? ErrAngl { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<ElemTablLanguage> ElemTablLanguage { get; set; }
    }
}
