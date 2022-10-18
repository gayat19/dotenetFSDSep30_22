using MyFirstAPI.Models;

namespace MyFirstAPI.Services
{
    public interface ILoginService
    {
        bool Login(UserDTO user);
        bool Register(User user);
    }
}
