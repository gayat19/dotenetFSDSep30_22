using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorModelLibrary
{
    public class MyNumbers
    {
        public virtual double Number1 { get; set; }
        public virtual double Number2 { get; set; }
        public void TakeNumbers()
        {
            Number1 = TakeNumebr(1);
            Number2 = TakeNumebr(2);
        }

        public double TakeNumebr(int v)
        {
            int number;
            Console.WriteLine("Please enter the {0} number",v);
            while(!Int32.TryParse(Console.ReadLine(),out number))
            {
                Console.WriteLine("Invalid input for {0} number. try again",v);
            }
            return number;
        }
        public override string ToString()
        {
            return "The numbers are "+Number1+" and "+Number2;
        }
    }
}
