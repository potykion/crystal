using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class MnOpTablInvariant
    {
        public MnOpTablInvariant()
        {
            MnOpTablLanguage = new HashSet<MnOpTablLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        [Display(Name = "Lyambda")] public float? Lyambda { get; set; }
        [Display(Name = "Nw")] public float? Nw { get; set; }
        [Display(Name = "N2w")] public float? N2w { get; set; }
        [Display(Name = "Znakcon")] public string Znakcon { get; set; }
        [Display(Name = "K")] public float? K { get; set; }
        [Display(Name = "ErrKj")] public float? ErrKj { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<MnOpTablLanguage> MnOpTablLanguage { get; set; }
    }
}
