using PizzaModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PizzaStoreBL
{
    public interface IRepo
    {
        Pizza Add(Pizza item);//Create
        Pizza Get(int id);//Read
        ICollection<Pizza> GetAll();//'Read
        Pizza Update(Pizza item);//Update
        Pizza Delete(int id);//Delete

    }
}
