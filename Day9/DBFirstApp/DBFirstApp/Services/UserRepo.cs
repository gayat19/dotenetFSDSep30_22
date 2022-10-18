using DBFirstApp.Models;
using System.Diagnostics;

namespace DBFirstApp.Services
{
    public class UserRepo : IRepo
    {
        private dbRecruitSep2022Context _context;

        public UserRepo(dbRecruitSep2022Context context)
        {
            _context = context;
        }
        public TblUser Add(TblUser item)
        {
            try
            {
                _context.TblUsers.Add(item);//Attached but will not refect ion the database
                _context.SaveChanges();//Reflects in the databse for all DML operation
                return item;
            }
            catch (Exception e)
            {

               Debug.WriteLine(e.Message);
            }
            return null;
        }

        public TblUser Get(string username)
        {
            var user = _context.TblUsers.FirstOrDefault(x => x.Username == username);
            return user;
        }

        public IEnumerable<TblUser> GetAll()
        {
            if (_context.TblUsers.Count() == 0)
                return null;
            return _context.TblUsers.ToList();
        }
        public TblUser Update(TblUser item)
        {
           try{
                var user =Get(item.Username);
                if (user == null)
                    return null;
                user.Password = item.Password;
                user.Role = item.Role;
                _context.SaveChanges();
                return user;
            }
            catch (Exception e)
            {

               Debug.WriteLine(e.Message);
            }
            return null;


        }
        public TblUser Delete(string username)
        {
            try
            {
                var user = Get(username);
                if (user == null)
                    return null;
                _context.Remove(user);
                _context.SaveChanges();
                return user;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return null;
        }
    }
}
