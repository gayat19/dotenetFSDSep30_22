using MyFirstAPI.Models;

namespace MyFirstAPI.Services
{
    public interface ILoginService
    {
        UserDTO Login(UserDTO user);
        UserDTO Register(UserPassDTO user);
    }
}
