using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class EquationTabl
    {
        public int EquationId { get; set; }
        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public int Nomprop { get; set; }
        public string EquationName { get; set; }
        public string EquationHtml { get; set; }
        public string EquationJs { get; set; }
        public string EquationCoefficientsJs { get; set; }
        public double Xmin { get; set; }
        public double Xmax { get; set; }
        public string Xaxis { get; set; }
        public string Xmeasure { get; set; }
        public string Yaxis { get; set; }
        public string Ymeasure { get; set; }
        public string Xml { get; set; }
        public string Comment { get; set; }
        public int? Bknumber { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public HeadTablInvariant HeadClueNavigation { get; set; }
        public PropertiesInvariant NompropNavigation { get; set; }
    }
}
