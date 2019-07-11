using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcpr.Class
{
    /// <summary>
    /// It`s integer class
    /// </summary>
    public class IntegerDivision : ITwoArgumentsCalculator
    {
        /// <summary>
        /// It`s search integer value
        /// </summary>
        /// <param name="FirstElement">It`s first number</param>
        /// <param name="SecondElement">It`s second number</param>
        /// <returns></returns>
        public double Calculate(double FirstElement, double SecondElement)
        {
            if (SecondElement == 0) throw new Exception("делить на 0 нельзя ");
            return (int)(FirstElement / SecondElement);
        }
    }
}
