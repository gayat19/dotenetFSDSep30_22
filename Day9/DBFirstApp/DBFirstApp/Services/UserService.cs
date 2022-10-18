using DBFirstApp.Models;
using System.Diagnostics;

namespace DBFirstApp.Services
{
    public class UserService : IUserService
    {
        private readonly IRepo _repo;

        public UserService(IRepo repo)
        {
            _repo = repo;
        }
        public bool Login(TblUser user)
        {
            try
            {
                var myUser = _repo.Get(user.Username);
                if(myUser != null)
                {
                    if (user.Password == myUser.Password)
                        return true;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return false;
        }

        public bool Register(TblUser user)
        {
            try
            {
                var myUser = _repo.Get(user.Username);
                if (myUser == null)
                {
                    _repo.Add(user);
                    return true;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return false;
        }
    }
}
