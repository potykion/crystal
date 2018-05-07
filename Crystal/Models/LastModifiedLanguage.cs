using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class LastModifiedLanguage
    {
        public int Id { get; set; }
        public int LastModifiedId { get; set; }
        public int LanguageId { get; set; }
        public string Text { get; set; }

        public LastModifiedInvariant LastModified { get; set; }
    }
}
