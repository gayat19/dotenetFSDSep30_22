using PizzaModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreBL
{
    public class PizzaStore
    {
        Repository repository;
        public PizzaStore()
        {
            repository = new Repository();
        }
        public void AddPizzaStock()
        {
            string choice = "No";
            do
            {
                Pizza pizza = new Pizza();
                pizza.TakePizzaDetails();
                repository.Add(pizza);
                Console.WriteLine("Do you want to enter one more pizza detail??");
                choice = Console.ReadLine().ToUpper();
            } while (choice != "NO");
        }
        public void UpdatePizzaPrice()
        {
            Console.WriteLine("Please enter teh pizza id for updating");
            int id = int.Parse(Console.ReadLine());
            Pizza pizza = repository.Get(id);
            if(pizza != null)
            {
                Console.WriteLine(pizza);
                Console.WriteLine("Please enter the updated price");
                float newPrice=float.Parse(Console.ReadLine());
                Pizza newPizza = new Pizza { Id = id, Price = newPrice };
                repository.Update(newPizza);
            }
            else
                Console.WriteLine("No pizza with that id is present");
        }
        public Pizza GetPizza(int id)
        {
            return repository.Get(id);
        }
        public void DisplayPizza()
        {
            ICollection<Pizza> pizzas = repository.GetAll();
            foreach (var item in pizzas)
            {
                Console.WriteLine(item);
                Console.WriteLine("-------------------------");
            }
        }
    }
}
