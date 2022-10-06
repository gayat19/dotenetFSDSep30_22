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
            //Pizza pizza = null;
            //for (int i = 0; i < pizzas.Count; i++)
            //{
            //    if(pizzas[i].Id == id)
            //    {
            //        pizza = pizzas[i];
            //        break;
            //    }
            //}
            //Predicate<Pizza> findPizza = (p) => p.Id == id;
            //Pizza pizza = pizzas.Find(findPizza);
            // Pizza pizza = pizzas.Find((p) => p.Id == id);
            //select * from pizzas where id=101
            //var pizza = (from item in pizzas where item.Id == id select item).ToList();
            // return pizza[0];
            var pizza = pizzas.FirstOrDefault(p => p.Id == id);
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
