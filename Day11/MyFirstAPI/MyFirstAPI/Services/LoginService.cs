using MyFirstAPI.Models;

namespace MyFirstAPI.Services
{
    public class LoginService : ILoginService
    {
        private readonly IRepo<string, User> _repo;

        public LoginService(IRepo<string,User> repo)
        {
            _repo = repo;
        }
        public bool Login(UserDTO user)
        {
            var myUser = _repo.GetAll().FirstOrDefault(u=>u.Username==user.Username && u.Password == user.Password);
            if(myUser == null || myUser.Status != "Active")
                return false;
            return true;
        }

        public bool Register(User user)
        {
            var myUser = _repo.Add(user);
            if(myUser != null)
                return true;
            return false;
        }
    }
}
