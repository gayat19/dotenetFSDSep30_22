using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class GoldCustomer : Customer
    {
        public int ReffPoints { get; set; }
        public Customer[] RefferedCustomers { get; set; }
        //Changes the functionality of the base class methos
        public override void PrintCustomerDetails()
        {
            Console.WriteLine(Id + " " + Name + " " + Age + " " + Phone+" "+ReffPoints);
        }
       
    }
}
