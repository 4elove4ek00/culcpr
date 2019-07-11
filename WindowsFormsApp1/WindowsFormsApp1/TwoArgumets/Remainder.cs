using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcpr.Class
{
    /// <summary>
    /// Class for remainder
    /// </summary>
    public class Remainder : ITwoArgumentsCalculator
    {
        /// <summary>
        /// It`s search remainder of dividing 2 numbers.
        /// </summary>
        /// <param name="FirstElement"></param>
        /// <param name="SecondElement"></param>
        /// <returns></returns>
        public double Calculate(double FirstElement, double SecondElement)
        {
            double result = FirstElement % SecondElement;
            return result;
        }
    }

}
