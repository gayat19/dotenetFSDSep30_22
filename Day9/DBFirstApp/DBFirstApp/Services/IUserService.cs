using DBFirstApp.Models;

namespace DBFirstApp.Services
{
    public interface IUserService
    {
        bool Login(TblUser user);
        bool Register(TblUser user);
    }
}
