using PizzaModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreBL
{
    public class CartPizza:Pizza
    {
        public int Quantity { get; set; }
        public override string ToString()
        {
            return "Id : " + Id + " Name : " + Name + " Price : " + Price + " Quantity : " + Quantity;
        }
    }
}
