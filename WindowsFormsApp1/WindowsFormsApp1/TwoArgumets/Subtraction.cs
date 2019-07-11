using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcpr
{
    
    public class Subtraction : ITwoArgumentsCalculator
    { /// <summary>
    /// It`s search subtraction 2 numbers.
    /// </summary>
    /// <param name="FirstElement">It`s first number</param>
    /// <param name="SecondElement">It`s second number</param>
    /// <returns></returns>
        public double Calculate(double FirstElement, double SecondElement)
        {
            double result = FirstElement - SecondElement;
            return result;
        }
    }
}
