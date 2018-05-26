using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class NlOpTablInvariant
    {
        public NlOpTablInvariant()
        {
            NlOpTablLanguage = new HashSet<NlOpTablLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        [Display(Name = "Lyambda")] public float? Lyambda { get; set; }
        [Display(Name = "Rij")] public float? Rij { get; set; }
        [Display(Name = "ErrRij")] public float? ErrRij { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<NlOpTablLanguage> NlOpTablLanguage { get; set; }
    }
}
