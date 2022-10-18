using System.ComponentModel.DataAnnotations;

namespace DBFirstApp.Models
{
    public class UserVM :TblUser
    {
        Dictionary<string, string> roles = new Dictionary<string, string>();
        public UserVM()
        {
            roles = new Dictionary<string, string>();
            roles.Add("admin", "Administrator");
            roles.Add("user", "Normal User");
            roles.Add("dummy", "Dummy User");
        }
        [Compare("Password",ErrorMessage ="Password Mismatch")]
        public string RePassword { get; set; }
        public Dictionary<string, string> Roles { get
            {
                return roles;
            } 
            set
            {
                roles = value;
            } 
        }

    }
}
