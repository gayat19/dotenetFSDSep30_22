using FirstWebApp.Models;

namespace FirstWebApp.Services
{
    public interface ILoginService
    {
        bool Login(User user);
        bool Register(User user);
    }
}
