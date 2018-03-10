using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class PropertiesLanguage
    {
        public int Id { get; set; }
        public int PropertiesId { get; set; }
        public int LanguageId { get; set; }
        public string Nazvprop { get; set; }

        public PropertiesInvariant Properties { get; set; }
    }
}
