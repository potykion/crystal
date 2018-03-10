using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class PropertiesInvariant
    {
        public PropertiesInvariant()
        {
            EquationTabl = new HashSet<EquationTabl>();
            PropertiesLanguage = new HashSet<PropertiesLanguage>();
        }

        public int Nomprop { get; set; }
        public string Html { get; set; }
        public string TableName { get; set; }

        public ICollection<EquationTabl> EquationTabl { get; set; }
        public ICollection<PropertiesLanguage> PropertiesLanguage { get; set; }
    }
}
