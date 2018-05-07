using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class HeadTablInvariant
    {
        public HeadTablInvariant()
        {
            AcOpTablInvariant = new HashSet<AcOpTablInvariant>();
            CuryTablInvariant = new HashSet<CuryTablInvariant>();
            DecrTablInvariant = new HashSet<DecrTablInvariant>();
            DensTablInvariant = new HashSet<DensTablInvariant>();
            EquationTabl = new HashSet<EquationTabl>();
            GrafTablInvariant = new HashSet<GrafTablInvariant>();
            HardTablInvariant = new HashSet<HardTablInvariant>();
            HeadTablLanguage = new HashSet<HeadTablLanguage>();
            HeatTablInvariant = new HashSet<HeatTablInvariant>();
            LitrTabl = new HashSet<LitrTabl>();
            PlavTablInvariant = new HashSet<PlavTablInvariant>();
            RefrTablLanguage = new HashSet<RefrTablLanguage>();
            SingTabl = new HashSet<SingTabl>();
            SistTabl = new HashSet<SistTabl>();
            SuspTablInvariant = new HashSet<SuspTablInvariant>();
            Wavepure = new HashSet<Wavepure>();
        }

        public int HeadClue { get; set; }
        public string System { get; set; }
        public string Help { get; set; }
        public int Class { get; set; }
        public string SystemUrl { get; set; }

        public ICollection<AcOpTablInvariant> AcOpTablInvariant { get; set; }
        public ICollection<CuryTablInvariant> CuryTablInvariant { get; set; }
        public ICollection<DecrTablInvariant> DecrTablInvariant { get; set; }
        public ICollection<DensTablInvariant> DensTablInvariant { get; set; }
        public ICollection<EquationTabl> EquationTabl { get; set; }
        public ICollection<GrafTablInvariant> GrafTablInvariant { get; set; }
        public ICollection<HardTablInvariant> HardTablInvariant { get; set; }
        public ICollection<HeadTablLanguage> HeadTablLanguage { get; set; }
        public ICollection<HeatTablInvariant> HeatTablInvariant { get; set; }
        public ICollection<LitrTabl> LitrTabl { get; set; }
        public ICollection<PlavTablInvariant> PlavTablInvariant { get; set; }
        public ICollection<RefrTablLanguage> RefrTablLanguage { get; set; }
        public ICollection<SingTabl> SingTabl { get; set; }
        public ICollection<SistTabl> SistTabl { get; set; }
        public ICollection<SuspTablInvariant> SuspTablInvariant { get; set; }
        public ICollection<Wavepure> Wavepure { get; set; }
    }
}
