using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcpr.Class
{
    /// <summary>
    /// It`s Exponentiation class
    /// </summary>
    public class Exponentiation : ITwoArgumentsCalculator
    {
        /// <summary>
        /// It`s search pow 2 numbers
        /// </summary>
        /// <param name="FirstElement">First number</param>
        /// <param name="SecondElement">Second number</param>
        /// <returns></returns>
        public double Calculate(double FirstElement, double SecondElement)
        {
            double result = Math.Pow(FirstElement, SecondElement);
            return result;
        }
    }
}
