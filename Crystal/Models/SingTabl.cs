using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class SingTabl
    {
        public SingTabl()
        {
            AcOpTablInvariant = new HashSet<AcOpTablInvariant>();
            ConstSelInvariant = new HashSet<ConstSelInvariant>();
            DecrTablLanguage = new HashSet<DecrTablLanguage>();
            DensTablLanguage = new HashSet<DensTablLanguage>();
            DielDissLanguage = new HashSet<DielDissLanguage>();
            DielectrInvariant = new HashSet<DielectrInvariant>();
            ElOpTablLanguage = new HashSet<ElOpTablLanguage>();
            Elastic1Invariant = new HashSet<Elastic1Invariant>();
            ElemTablInvariant = new HashSet<ElemTablInvariant>();
            ElemTablNewLanguage = new HashSet<ElemTablNewLanguage>();
            EsOpTablLanguage = new HashSet<EsOpTablLanguage>();
            HardTablLanguage = new HashSet<HardTablLanguage>();
            HeatExpnLanguage = new HashSet<HeatExpnLanguage>();
            MechTablLanguage = new HashSet<MechTablLanguage>();
            MnOpTablInvariant = new HashSet<MnOpTablInvariant>();
            ModfTablInvariant = new HashSet<ModfTablInvariant>();
            NlOpTablLanguage = new HashSet<NlOpTablLanguage>();
            PzElTablInvariant = new HashSet<PzElTablInvariant>();
            RefrcIndInvariant = new HashSet<RefrcIndInvariant>();
            Wavepure = new HashSet<Wavepure>();
        }

        public int HeadClue { get; set; }
        public string SingType { get; set; }
        public decimal? SingClue { get; set; }

        public HeadTablInvariant HeadClueNavigation { get; set; }
        public ICollection<AcOpTablInvariant> AcOpTablInvariant { get; set; }
        public ICollection<ConstSelInvariant> ConstSelInvariant { get; set; }
        public ICollection<DecrTablLanguage> DecrTablLanguage { get; set; }
        public ICollection<DensTablLanguage> DensTablLanguage { get; set; }
        public ICollection<DielDissLanguage> DielDissLanguage { get; set; }
        public ICollection<DielectrInvariant> DielectrInvariant { get; set; }
        public ICollection<ElOpTablLanguage> ElOpTablLanguage { get; set; }
        public ICollection<Elastic1Invariant> Elastic1Invariant { get; set; }
        public ICollection<ElemTablInvariant> ElemTablInvariant { get; set; }
        public ICollection<ElemTablNewLanguage> ElemTablNewLanguage { get; set; }
        public ICollection<EsOpTablLanguage> EsOpTablLanguage { get; set; }
        public ICollection<HardTablLanguage> HardTablLanguage { get; set; }
        public ICollection<HeatExpnLanguage> HeatExpnLanguage { get; set; }
        public ICollection<MechTablLanguage> MechTablLanguage { get; set; }
        public ICollection<MnOpTablInvariant> MnOpTablInvariant { get; set; }
        public ICollection<ModfTablInvariant> ModfTablInvariant { get; set; }
        public ICollection<NlOpTablLanguage> NlOpTablLanguage { get; set; }
        public ICollection<PzElTablInvariant> PzElTablInvariant { get; set; }
        public ICollection<RefrcIndInvariant> RefrcIndInvariant { get; set; }
        public ICollection<Wavepure> Wavepure { get; set; }
    }
}
