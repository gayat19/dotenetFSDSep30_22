using CalculatorModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCalculator
{
    public interface ICalculate
    {
        double Add(MyNumbers numbers);
        double Divide(MyNumbers numbers);
    }
}
