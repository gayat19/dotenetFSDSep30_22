using CalculatorModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCalculator
{
    public class Calculator : ICalculate
    {
        public double Add(MyNumbers numbers)
        {
            double sum = numbers.Number1 + numbers.Number2;
            return sum;
        }

        public double Divide(MyNumbers numbers)
        {
            double result = numbers.Number1 / numbers.Number2;
            return result;
        }
    }
}
