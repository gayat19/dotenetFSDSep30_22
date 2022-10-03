using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreBL
{
    public class DuplicatePizzaException: Exception
    {
        private string _message;
        public DuplicatePizzaException()
        {
            _message = "Is already exists";
        }
        public DuplicatePizzaException(int id)
        {
            _message = id+ " Is already exists";
        }
        public override string Message => _message;
    }
}
