using System;
using System.Collections.Generic;

namespace DBFirstApp.Models
{
    public partial class TblProfile
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        public string? Qualification { get; set; }
        public bool? IsEmployed { get; set; }
        public int? NoticePeriod { get; set; }
        public double? CurrentCtc { get; set; }
        public string? Username { get; set; }

        public virtual TblUser? UsernameNavigation { get; set; }
    }
}
