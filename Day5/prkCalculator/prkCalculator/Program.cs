using CalculatorModelLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCalculator
{
    public class Program
    {
        MyNumbers numbers;
        Calculator calculator;
        public Program()
        {
            numbers = new MyNumbers();
            calculator = new Calculator();
        }
        public Program(MyNumbers _numbers,Calculator _calculator)
        {
            numbers = _numbers;
            calculator = _calculator;
        }
        public bool Calculate(int choice)
        {
            bool status = false;
            switch (choice)
            {
                case 1:
                    //numbers.TakeNumbers();
                    double result = calculator.Add(numbers);
                    PrintResult("Addision", result);
                    status = true;
                    break;
                case 2:
                    //numbers.TakeNumbers();
                    double result1 = calculator.Divide(numbers);
                    PrintResult("Division", result1);
                    status = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again. If you wish to exit enter 0");
                    break;
            }
            return status;
        }
        [ExcludeFromCodeCoverage]
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

                Calculate(choice);
            } while (choice!=0);

        }
        [ExcludeFromCodeCoverage]
        private void PrintResult(string v, double result)
        {
            Console.WriteLine(numbers);
            Console.WriteLine(" The "+v+" has resulted in "+result);
        }
        [ExcludeFromCodeCoverage]
        private void PrintMenu()
        {
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Divide");
        }
        [ExcludeFromCodeCoverage]
        static void Main(string[] args)
        {
            new Program().ImplementCalculation();
            Console.ReadKey();
        }
    }
}
