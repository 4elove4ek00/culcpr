using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcpr.Class
{
    
    public class Fractionation: ITwoArgumentsCalculator
    {
        /// <summary>
    /// It`s search first number in pow (1/second number)
    /// </summary>
    /// <param name="FirstElement">First number</param>
    /// <param name="SecondElement">Second number</param>
    /// <returns></returns>
        public double Calculate(double FirstElement, double SecondElement)
        {
            double result = Math.Pow (FirstElement, (1/SecondElement));
            return result;
        }
    }
}
