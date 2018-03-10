using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class ModfTablLanguage
    {
        public int Id { get; set; }
        public int ModfTablId { get; set; }
        public int LanguageId { get; set; }
        public string SpaceGrp { get; set; }

        public ModfTablInvariant ModfTabl { get; set; }
    }
}
