using System.ComponentModel.DataAnnotations;

namespace FirstWebApp.Models
{
    public class User
    {
        [Required(ErrorMessage ="Username cannot be empty")]
        public string? Username { get; set; }
        [Required(ErrorMessage = "Password cannot be empty")]
        [RegularExpression("[A-Za-z][A-Za-z]*",ErrorMessage ="Invalid Password. Password should contain onlt alphabets")]

        public string? Password { get; set; }
    }
}
