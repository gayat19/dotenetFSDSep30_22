using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaModelLibrary
{
    public class Pizza:IComparable<Pizza>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Type { get; set; }
        public bool IsVeg { get; set; }
        public string Pic { get; set; }
        public string Description { get; set; }

        public Pizza()
        {
            Id = 0;
            Name = "";
            Price = 1.0f;
            Pic = "";
            Description = "";
            IsVeg = false;
        }
        public Pizza(string name, float price, string type, bool isVeg, string pic, string description)
        {
            Name = name;
            Price = price;
            Type = type;
            IsVeg = isVeg;
            Pic = pic;
            Description = description;
        }

        public Pizza(int id, string name, float price, string type, bool isVeg, string pic, string description)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
            IsVeg = isVeg;
            Pic = pic;
            Description = description;
        }
        public void TakePizzaDetails()
        {
            try
            {
                Console.WriteLine("Please enter the pizza Id");
                //Error handling
                int id = 0;
                while(Int32.TryParse(Console.ReadLine(), out id) ==false)
                    Console.WriteLine("Invalid entry for Id. Try again with an Int");
                Id = id;
                Console.WriteLine("Please enter the pizza Name");
                Name = Console.ReadLine();
                Console.WriteLine("Please enter the pizza Price");
                Price = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the pizza Crust Type");
                Type = Console.ReadLine();
                Console.WriteLine("Is the pizza Veg??");
                IsVeg = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Please enter the pizza description");
                Description = Console.ReadLine();
            }
            //Exception handling
            catch (FormatException fe)
            {
                Console.WriteLine("Invalid Input.");
                Debug.WriteLine(fe.Message);
            }
        }
        public void PrintDetails()
        {
            string strData = "ID : " + Id +
                            "\nName : " + Name +
                            "\nPrice : Rs." + Price +
                            "\nVeg?? : " + IsVeg +
                            "\nCrust Type : " + Type +
                            "\nDescription : " + Description;
            Console.WriteLine(strData);
        }
        public override string ToString()
        {
            string strData = "ID : " + Id +
                           "\nName : " + Name +
                           "\nPrice : Rs." + Price +
                           "\nVeg?? : " + IsVeg +
                           "\nCrust Type : " + Type +
                           "\nDescription : " + Description;
            return strData;
        }
        public override bool Equals(object obj)
        {
            Pizza other = (Pizza)obj;
            return this.Id.Equals(other.Id);
        }
        public int CompareTo(Pizza other)
        {
            return this.Price.CompareTo(other.Price);
        }

    }
}
