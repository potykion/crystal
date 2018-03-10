using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class LastModifiedLanguage
    {
        public string Text { get; set; }
        public DateTime LastModified { get; set; }
        public int Id { get; set; }
        public int LanguageId { get; set; }
    }
}
