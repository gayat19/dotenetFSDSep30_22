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
    internal partial class Program
    {
        PizzaStore pizzaStore;
        Cart cart;
        //public delegate void MyDelegateType(int n1, int n2);//Creating a ref type
        //public delegate void MyDelegateFloatType(float n1, float n2);//Creating a ref type
        //public delegate void MyDelegateType<T>(T n1, T n2);//Generalize the declaration
        //MyDelegateType<int> myDelegate;//Create reff with specific types
        //MyDelegateType<float> myFloatDelegate;
        //MyDelegateType<string> myStringDelegate;
        Action<int, int> myDelegate;
        Action<float, float> myFloatDelegate;
        Action<string, string> myStringDelegate;
        void Add(int num1,int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine("The sum is "+sum);
        }
        void Product(int num1, int num2)
        {
            int sum = num1 * num2;
            Console.WriteLine("The product is " + sum);
        }
        void ProductFloat(float num1, float num2)
        {
            float sum = num1 * num2;
            Console.WriteLine("The product is " + sum);
        }
        void UseDelegate()
        {
            //myDelegate = new MyDelegateType<int>(Add);
            myDelegate = new Action<int, int>(Add);
            myDelegate += Product;
            //myFloatDelegate = new MyDelegateType<float>(ProductFloat);
            myFloatDelegate = new Action<float,float>(ProductFloat);
            //Annon method - can be used with delegate for invocation
            //myStringDelegate += delegate (string s1, string s2)
            //{
            //    Console.WriteLine(s1 + " " + s2);
            //};
            //myStringDelegate =(s1,s2) =>
            //{
            //    Console.WriteLine(s1 + " " + s2);
            //};
            myStringDelegate = (s1, s2) => Console.WriteLine(s1 + " " + s2);
        }
        public Program()
        {
            //Repository repository = new Repository();
            DBRepository repository = new DBRepository();
            pizzaStore = new PizzaStore(repository);
            cart = new Cart();
        }
        static void Main(string[] args)
        {
            //Program program = new Program();
            //program.InitializeStore();
            //program.Shop();
            //program.UseDelegate();
            //program.myStringDelegate("Hello","World");
            //program.myFloatDelegate(10.2f,34.5f);
            //program.myDelegate(10, 20);//Invoking the method using the delegate
            //Action<int, int> myDelegate = (n1, n2) => Console.WriteLine("The sum is "+(n1+n2));
            //myDelegate(10, 20);
            //Func<int,int> myFunc = (num1) => num1+10;
            //Console.WriteLine(myFunc(100));
            //string name = Console.ReadLine();
            //Predicate<string> check = (nm) => name.Length > 5;
            //Console.WriteLine(check(name)); 
           // int[] arr = { 90, 78, 89, 34, 98, 67 };
            List<int> arr = new List<int>() { 90, 78, 89, 34, 98, 67 };
            var scores = from n in arr where n > num1 select n;
            //var scores = arr.Where(n => n > 70);
            foreach (var item in scores)
            {
                Console.WriteLine(item);
            }
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
