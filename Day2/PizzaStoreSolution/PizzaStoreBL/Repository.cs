using PizzaModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreBL
{
    public class Repository : IRepo
    {
        List<Pizza> pizzas = new List<Pizza>()
        {
            new Pizza(){Id=102,Name="Abc",Price=123.4f},
            new Pizza(){Id=101,Name="AAb",Price=233.4f}
        };
        public Pizza Add(Pizza item)
        {
            Pizza myPizza = Get(item.Id);
            if (myPizza == null)
            {
                pizzas.Add(item);
                return item;
            }
            throw new DuplicatePizzaException();
            return null;
        }

        public Pizza Get(int id)
        {
            Pizza pizza = null;
            for (int i = 0; i < pizzas.Count; i++)
            {
                if(pizzas[i].Id == id)
                {
                    pizza = pizzas[i];
                    break;
                }
            }
            return pizza;
        }

        public ICollection<Pizza> GetAll()
        {
            return pizzas;
        }

        public Pizza Update(Pizza item)
        {
            Pizza myPizza = Get(item.Id);
            if(myPizza != null)
            {
                myPizza.Price = item.Price;
            }
            return myPizza;
        }
        public Pizza Delete(int id)
        {
            Pizza myPizza = Get(id);
            if (myPizza != null)
            {
                pizzas.Remove(myPizza);//Works only if the equals method is overriden
            }
            return myPizza;
        }
    }
}
