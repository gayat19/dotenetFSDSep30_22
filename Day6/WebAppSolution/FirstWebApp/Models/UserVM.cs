using System.ComponentModel.DataAnnotations;

namespace FirstWebApp.Models
{
    public class UserVM:User
    {
        [Compare("Password",ErrorMessage ="Password Missmatch")]
        public string? ConfimPassword { get; set; }
    }
}
