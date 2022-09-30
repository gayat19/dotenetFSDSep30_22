using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Product
    {
        public Product()
        {
            //default constructor
            Id = 100;
        }
        public Product(string name, int quantity, int id, float price)
        {
            Name = name;
            Quantity = quantity;
            Id = id;
            Price = price;
        }

        //int ID;
        //public string other;
        private float _price;
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Id { get; set; }
        public float Price {
            get
            {   
                return _price;
            }set {
                _price = (float)(value + (value * 12.2 / 100));
            }
        }
        public void GetProductDetailsFromConsole()
        {
            Console.WriteLine("Please enter the product Id");
            Id = Convert.ToInt32(Console.ReadLine());
            GetProductDetailsFromConsole(Id);
        }
        public void GetProductDetailsFromConsole(int id)
        {
            Id = id;
            Console.WriteLine("Please enter the product Name");
            Name = Console.ReadLine();
            Console.WriteLine("Please entert the product price");
            Price = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the product quantity");
            Quantity = Convert.ToInt32(Console.ReadLine());
        }
        public static Product operator+(Product p1,Product p2)
        {
            Product p3 = new Product();
            p3.Name = p1.Name;
            p3.Price = p1.Price;
            p3.Id = p1.Id;
            p3.Quantity = p1.Quantity + p2.Quantity;
            return p3;
        }
    }
}
