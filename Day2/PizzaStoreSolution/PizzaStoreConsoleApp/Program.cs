using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaModelLibrary;
using PizzaStoreBL;

namespace PizzaStoreConsoleApp
{
    internal class Program
    {
        PizzaStore pizzaStore;
        Cart cart;
        public Program()
        {
            pizzaStore = new PizzaStore();
            cart = new Cart();
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.InitializeStore();
            program.Shop();
            Console.ReadKey();
        }

        private void Shop()
        {
            int choice = 0;
            do
            {
                PrintMenu();
                Console.WriteLine("Please enter a option ");
                while(!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid entry");
                }
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Bye....");
                        break;
                     case 1:
                        pizzaStore.DisplayPizza();
                        break;
                    case 2:
                        Console.WriteLine("Please enter the Id of pizza you wish to purchase");
                        int id = int.Parse(Console.ReadLine());
                        Pizza pizza = pizzaStore.GetPizza(id);
                        cart.AddToCart(pizza);
                        break;
                    case 3:
                        foreach (var item in cart.GetCart())
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Please enter the Id of pizza you wish to remove");
                        int pid = int.Parse(Console.ReadLine());
                        cart.RemoveFromCart(pid);
                        break;
                    case 5:
                        cart.ClearCart();
                        break;
                    case 6:
                        Console.WriteLine("We have despached your order");
                        float amount = 0;
                        foreach (var item in cart.GetCart())
                        {
                            amount = item.Price * item.Quantity;
                        }
                        if(amount > 250)
                            Console.WriteLine("your final bill amountis Rs."+amount);
                        else
                        {
                            amount = amount + 100;
                            Console.WriteLine("your final bill amount(Rs. 100 added for delivery) is Rs." + amount);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again");
                        break;
                }
            } while (choice!=0);
        }

        private void PrintMenu()
        {
            Console.WriteLine("1. PrintPizza");
            Console.WriteLine("2. Buy Pizza");
            Console.WriteLine("3. Print Cart");
            Console.WriteLine("4. Edit Cart");
            Console.WriteLine("5. Clear Cart");
            Console.WriteLine("6. Confirm Order");
            Console.WriteLine("0. Exit");
        }

        private void InitializeStore()
        {
            try
            {
                try
                {
                    pizzaStore.AddPizzaStock();
                }
                catch (DuplicatePizzaException dpe)
                {
                    Console.WriteLine("The pizza Id already is present.");
                    Debug.WriteLine(dpe.Message);
                }
                //pizzaStore.UpdatePizzaPrice();
            }
            catch (Exception e)
            {
                Console.WriteLine("Opps something went wrong");
                Debug.WriteLine(e.Message);
            }
           finally {
                pizzaStore.DisplayPizza();
            }
               
        }
    }
}
