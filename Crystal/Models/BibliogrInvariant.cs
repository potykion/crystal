using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class BibliogrInvariant
    {
        public BibliogrInvariant()
        {
            AcOpTablInvariant = new HashSet<AcOpTablInvariant>();
            BibliogrLanguage = new HashSet<BibliogrLanguage>();
            ConstSelInvariant = new HashSet<ConstSelInvariant>();
            CuryTablLanguage = new HashSet<CuryTablLanguage>();
            DecrTablLanguage = new HashSet<DecrTablLanguage>();
            DensTablLanguage = new HashSet<DensTablLanguage>();
            DielDissLanguage = new HashSet<DielDissLanguage>();
            DielectrInvariant = new HashSet<DielectrInvariant>();
            ElOpTablLanguage = new HashSet<ElOpTablLanguage>();
            Elastic1Invariant = new HashSet<Elastic1Invariant>();
            ElemTablInvariant = new HashSet<ElemTablInvariant>();
            ElemTablNewLanguage = new HashSet<ElemTablNewLanguage>();
            EquationTabl = new HashSet<EquationTabl>();
            EsOpTablLanguage = new HashSet<EsOpTablLanguage>();
            HardTablLanguage = new HashSet<HardTablLanguage>();
            HeatExpnLanguage = new HashSet<HeatExpnLanguage>();
            HeatTablInvariant = new HashSet<HeatTablInvariant>();
            MechTablLanguage = new HashSet<MechTablLanguage>();
            MnOpTablInvariant = new HashSet<MnOpTablInvariant>();
            ModfTablInvariant = new HashSet<ModfTablInvariant>();
            NlOpTablLanguage = new HashSet<NlOpTablLanguage>();
            PlavTablLanguage = new HashSet<PlavTablLanguage>();
            PzElTablInvariant = new HashSet<PzElTablInvariant>();
            RefrcIndInvariant = new HashSet<RefrcIndInvariant>();
            SuspTablLanguage = new HashSet<SuspTablLanguage>();
            Wavepure = new HashSet<Wavepure>();
        }

        public int Bknumber { get; set; }
        public string Doi { get; set; }

        public ICollection<AcOpTablInvariant> AcOpTablInvariant { get; set; }
        public ICollection<BibliogrLanguage> BibliogrLanguage { get; set; }
        public ICollection<ConstSelInvariant> ConstSelInvariant { get; set; }
        public ICollection<CuryTablLanguage> CuryTablLanguage { get; set; }
        public ICollection<DecrTablLanguage> DecrTablLanguage { get; set; }
        public ICollection<DensTablLanguage> DensTablLanguage { get; set; }
        public ICollection<DielDissLanguage> DielDissLanguage { get; set; }
        public ICollection<DielectrInvariant> DielectrInvariant { get; set; }
        public ICollection<ElOpTablLanguage> ElOpTablLanguage { get; set; }
        public ICollection<Elastic1Invariant> Elastic1Invariant { get; set; }
        public ICollection<ElemTablInvariant> ElemTablInvariant { get; set; }
        public ICollection<ElemTablNewLanguage> ElemTablNewLanguage { get; set; }
        public ICollection<EquationTabl> EquationTabl { get; set; }
        public ICollection<EsOpTablLanguage> EsOpTablLanguage { get; set; }
        public ICollection<HardTablLanguage> HardTablLanguage { get; set; }
        public ICollection<HeatExpnLanguage> HeatExpnLanguage { get; set; }
        public ICollection<HeatTablInvariant> HeatTablInvariant { get; set; }
        public ICollection<MechTablLanguage> MechTablLanguage { get; set; }
        public ICollection<MnOpTablInvariant> MnOpTablInvariant { get; set; }
        public ICollection<ModfTablInvariant> ModfTablInvariant { get; set; }
        public ICollection<NlOpTablLanguage> NlOpTablLanguage { get; set; }
        public ICollection<PlavTablLanguage> PlavTablLanguage { get; set; }
        public ICollection<PzElTablInvariant> PzElTablInvariant { get; set; }
        public ICollection<RefrcIndInvariant> RefrcIndInvariant { get; set; }
        public ICollection<SuspTablLanguage> SuspTablLanguage { get; set; }
        public ICollection<Wavepure> Wavepure { get; set; }
    }
}
