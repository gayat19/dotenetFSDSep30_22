using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreBL
{
    public interface IRepoChild : IRepo
    {
        void DeleteAll();
    }
}
