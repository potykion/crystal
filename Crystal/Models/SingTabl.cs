﻿using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class SingTabl
    {
        public SingTabl()
        {
            AcOpTablInvariant = new HashSet<AcOpTablInvariant>();
            ConstSelInvariant = new HashSet<ConstSelInvariant>();
            DecrTablInvariant = new HashSet<DecrTablInvariant>();
            DensTablInvariant = new HashSet<DensTablInvariant>();
            DielDissInvariant = new HashSet<DielDissInvariant>();
            DielectrInvariant = new HashSet<DielectrInvariant>();
            ElOpTablInvariant = new HashSet<ElOpTablInvariant>();
            Elastic1Invariant = new HashSet<Elastic1Invariant>();
            ElemTablInvariant = new HashSet<ElemTablInvariant>();
            ElemTablNewInvariant = new HashSet<ElemTablNewInvariant>();
            EsOpTablInvariant = new HashSet<EsOpTablInvariant>();
            HardTablInvariant = new HashSet<HardTablInvariant>();
            HeatExpnInvariant = new HashSet<HeatExpnInvariant>();
            MechTablInvariant = new HashSet<MechTablInvariant>();
            MnOpTablInvariant = new HashSet<MnOpTablInvariant>();
            ModfTablInvariant = new HashSet<ModfTablInvariant>();
            NlOpTablInvariant = new HashSet<NlOpTablInvariant>();
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
        public ICollection<DecrTablInvariant> DecrTablInvariant { get; set; }
        public ICollection<DensTablInvariant> DensTablInvariant { get; set; }
        public ICollection<DielDissInvariant> DielDissInvariant { get; set; }
        public ICollection<DielectrInvariant> DielectrInvariant { get; set; }
        public ICollection<ElOpTablInvariant> ElOpTablInvariant { get; set; }
        public ICollection<Elastic1Invariant> Elastic1Invariant { get; set; }
        public ICollection<ElemTablInvariant> ElemTablInvariant { get; set; }
        public ICollection<ElemTablNewInvariant> ElemTablNewInvariant { get; set; }
        public ICollection<EsOpTablInvariant> EsOpTablInvariant { get; set; }
        public ICollection<HardTablInvariant> HardTablInvariant { get; set; }
        public ICollection<HeatExpnInvariant> HeatExpnInvariant { get; set; }
        public ICollection<MechTablInvariant> MechTablInvariant { get; set; }
        public ICollection<MnOpTablInvariant> MnOpTablInvariant { get; set; }
        public ICollection<ModfTablInvariant> ModfTablInvariant { get; set; }
        public ICollection<NlOpTablInvariant> NlOpTablInvariant { get; set; }
        public ICollection<PzElTablInvariant> PzElTablInvariant { get; set; }
        public ICollection<RefrcIndInvariant> RefrcIndInvariant { get; set; }
        public ICollection<Wavepure> Wavepure { get; set; }
    }
}
