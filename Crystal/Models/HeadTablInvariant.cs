using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class HeadTablInvariant
    {
        public HeadTablInvariant()
        {
            AcOpTablInvariant = new HashSet<AcOpTablInvariant>();
            CuryTablLanguage = new HashSet<CuryTablLanguage>();
            DecrTablLanguage = new HashSet<DecrTablLanguage>();
            DensTablLanguage = new HashSet<DensTablLanguage>();
            EquationTabl = new HashSet<EquationTabl>();
            GrafTablLanguage = new HashSet<GrafTablLanguage>();
            HardTablLanguage = new HashSet<HardTablLanguage>();
            HeadTablLanguage = new HashSet<HeadTablLanguage>();
            HeatTablInvariant = new HashSet<HeatTablInvariant>();
            LitrTabl = new HashSet<LitrTabl>();
            PlavTablLanguage = new HashSet<PlavTablLanguage>();
            RefrTablLanguage = new HashSet<RefrTablLanguage>();
            SingTabl = new HashSet<SingTabl>();
            SistTabl = new HashSet<SistTabl>();
            SuspTablLanguage = new HashSet<SuspTablLanguage>();
            Wavepure = new HashSet<Wavepure>();
        }

        public int HeadClue { get; set; }
        public string System { get; set; }
        public string Help { get; set; }
        public int Class { get; set; }
        public string SystemUrl { get; set; }

        public ICollection<AcOpTablInvariant> AcOpTablInvariant { get; set; }
        public ICollection<CuryTablLanguage> CuryTablLanguage { get; set; }
        public ICollection<DecrTablLanguage> DecrTablLanguage { get; set; }
        public ICollection<DensTablLanguage> DensTablLanguage { get; set; }
        public ICollection<EquationTabl> EquationTabl { get; set; }
        public ICollection<GrafTablLanguage> GrafTablLanguage { get; set; }
        public ICollection<HardTablLanguage> HardTablLanguage { get; set; }
        public ICollection<HeadTablLanguage> HeadTablLanguage { get; set; }
        public ICollection<HeatTablInvariant> HeatTablInvariant { get; set; }
        public ICollection<LitrTabl> LitrTabl { get; set; }
        public ICollection<PlavTablLanguage> PlavTablLanguage { get; set; }
        public ICollection<RefrTablLanguage> RefrTablLanguage { get; set; }
        public ICollection<SingTabl> SingTabl { get; set; }
        public ICollection<SistTabl> SistTabl { get; set; }
        public ICollection<SuspTablLanguage> SuspTablLanguage { get; set; }
        public ICollection<Wavepure> Wavepure { get; set; }
    }
}
