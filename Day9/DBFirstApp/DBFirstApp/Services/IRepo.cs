using DBFirstApp.Models;

namespace DBFirstApp.Services
{
    public interface IRepo
    {
        TblUser Add(TblUser item);
        TblUser Get(string username);
        IEnumerable<TblUser> GetAll();
        TblUser Update(TblUser item);
        TblUser Delete(string username);
   
    }
}
