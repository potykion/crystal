using System;
using System.Collections.Generic;

namespace Crystal.Models
{
    public partial class Users
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime? LastLogin { get; set; }
        public int LoginCount { get; set; }
        public string Email { get; set; }
        public string LastIp { get; set; }
        public DateTime? Licence { get; set; }
        public int AccessMode { get; set; }
        public string Comments { get; set; }
        public string AccessIp { get; set; }
    }
}
