using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class UsersInfo
    {
        public int UserId { get; set; }
        public int AccessMode { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Comments { get; set; }
        public int UpdateStatus { get; set; }
    }
}
