﻿using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class DensTablInvariant
    {
        public DensTablInvariant()
        {
            DensTablLanguage = new HashSet<DensTablLanguage>();
        }

        public int HeadClue { get; set; }
        public string SingCode { get; set; }
        public decimal? Density { get; set; }
        public decimal? ErrDens { get; set; }
        public int? Bknumber { get; set; }
        public int Id { get; set; }

        public BibliogrInvariant BknumberNavigation { get; set; }
        public HeadTablInvariant HeadClueNavigation { get; set; }
        public SingTabl SingTabl { get; set; }
        public ICollection<DensTablLanguage> DensTablLanguage { get; set; }
    }
}
