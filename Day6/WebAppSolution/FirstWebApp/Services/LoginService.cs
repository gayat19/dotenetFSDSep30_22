using FirstWebApp.Models;

namespace FirstWebApp.Services
{
    public class LoginService : ILoginService
    {
        static List<User> users = new List<User>()
        {
            new User{Username="Ramu",Password="ramu"},
            new User{Username="Somu",Password="somu"}
        };
        public bool Login(User user)
        {
            var myUser = users.SingleOrDefault(u => u.Username == user.Username);
            if(myUser != null)
            {
                if(myUser.Password == user.Password)
                    return true;
            }
            return false;
        }

        public bool Register(User user)
        {
            var myUser = users.SingleOrDefault(u => u.Username == user.Username);
            if (myUser != null)
            {
                return false;
            }
            users.Add(user);
            return true;
        }
    }
}
