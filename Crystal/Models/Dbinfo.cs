using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class Dbinfo
    {
        public string Name { get; set; }
        public string Dburl { get; set; }
        public string DbgateUrl { get; set; }
        public string EmailManager { get; set; }
        public string WwwtemplatePage { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
        public int UpdateStatus { get; set; }
    }
}
