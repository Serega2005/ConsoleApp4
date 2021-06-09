using System;
using System.Collections.Generic;
using System.Text;

namespace Calc
{
    class Calculator
    {
        public double Calc(double num1, double num2, Calculators calc)
        {
            return calc.Invoke(num1, num2);
        }
    }
}
