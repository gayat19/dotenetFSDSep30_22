using System;
using System.Collections.Generic;

namespace DBFirstApp.Models
{
    public partial class TblUser
    {
        public TblUser()
        {
            TblProfiles = new HashSet<TblProfile>();
        }

        public string Username { get; set; } = null!;
        public string? Password { get; set; }
        public string? Role { get; set; }

        public virtual ICollection<TblProfile> TblProfiles { get; set; }
    }
}
