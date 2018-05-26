using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class DecrTablInvariant
    {
        public DecrTablInvariant()
        {
            DecrTablLanguage = new HashSet<DecrTablLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        [Display(Name = "WaveSpeed")] public float? WaveSpeed { get; set; }
        [Display(Name = "Decrement")] public float? Decrement { get; set; }
        [Display(Name = "DecrFreq")] public float? DecrFreq { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public HeadTablInvariant HeadClueNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<DecrTablLanguage> DecrTablLanguage { get; set; }
    }
}
