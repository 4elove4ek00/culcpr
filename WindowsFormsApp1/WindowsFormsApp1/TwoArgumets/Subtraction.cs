using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcpr
{
    public class Subtraction : ITwoArgumentsCalculator
    {
        public double Calculate(double FirstElement, double SecondElement)
        {
            double result = FirstElement - SecondElement;
            return result;
        }
    }
}
