using CalculatorModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCalculator
{
    internal class Program
    {
        MyNumbers numbers;
        Calculator calculator;
        public Program()
        {
            numbers = new MyNumbers();
            calculator = new Calculator();
        }
        public void ImplementCalculation()
        {
            int choice;
            do
            {
                PrintMenu();
                while (!Int32.TryParse(Console.ReadLine(),out choice))
                {
                    Console.WriteLine("Invalid entry");
                }
                
                switch (choice)
                {
                    case 1:
                        numbers.TakeNumbers();
                        double result = calculator.Add(numbers);
                        PrintResult("Addision", result);
                        break;
                    case 2:
                        numbers.TakeNumbers();
                        double result1 = calculator.Divide(numbers);
                        PrintResult("Division", result1);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again. If you wish to exit enter 0");
                        break;
                }
            } while (choice!=0);

        }

        private void PrintResult(string v, double result)
        {
            Console.WriteLine(numbers);
            Console.WriteLine(" The "+v+" has resulted in "+result);
        }

        private void PrintMenu()
        {
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Divide");
        }

        static void Main(string[] args)
        {
            new Program().ImplementCalculation();
            Console.ReadKey();
        }
    }
}
