using MyFirstAPI.Models;

namespace MyFirstAPI.Services
{
    public interface ITokenService
    {
        public string CreateToken(UserDTO user);
    }
}
