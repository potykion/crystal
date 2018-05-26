using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crystal.Models
{
    public partial class RefrcIndLanguage
    {
        public int Id { get; set; }
        public int RefrcIndId { get; set; }
        public int LanguageId { get; set; }
        [Display(Name = "MethodIn")] public string MethodIn { get; set; }
        public string MethodIn1 { get; set; }

        public RefrcIndInvariant RefrcInd { get; set; }
    }
}
