using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class LastModifiedInvariant
    {
        public LastModifiedInvariant()
        {
            LastModifiedLanguage = new HashSet<LastModifiedLanguage>();
        }

        public DateTime LastModified { get; set; }
        public int Id { get; set; }

        public ICollection<LastModifiedLanguage> LastModifiedLanguage { get; set; }
    }
}
