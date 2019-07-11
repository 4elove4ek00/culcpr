using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcpr.Class
{

    public class GeometricMean : ITwoArgumentsCalculator
    {
        /// <summary>
        /// this method find geometric mean of two arguments
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public double Calculate(double FirstElement, double SecondElement)
        {
            if(FirstElement * SecondElement<0) throw new Exception("отрицательное значение под корнем ");
            return Math.Sqrt(FirstElement * SecondElement);
        }
    }
}
