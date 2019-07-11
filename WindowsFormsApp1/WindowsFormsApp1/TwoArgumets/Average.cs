using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcpr.Class
{
    
   public class Average : ITwoArgumentsCalculator
    {
        /// <summary>
        /// It`s search medium math
        /// </summary>
        /// <param name="FirstElement">First number</param>
        /// <param name="SecondElement">Second number</param>
        /// <returns></returns>
        public double Calculate(double FirstElement, double SecondElement)
        {
            double result = (FirstElement + SecondElement) / 2; 
            return result;
        }
    }
}
