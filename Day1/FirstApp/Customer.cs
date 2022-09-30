using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        //Teh derived class is allowed to changeteh fucntionality of this method
        public virtual void PrintCustomerDetails()
        {
            Console.WriteLine(Id+" "+Name+" "+Age+" "+Phone);
        }
    }
}
