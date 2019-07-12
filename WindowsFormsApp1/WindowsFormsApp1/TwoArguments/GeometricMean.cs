using System;

namespace Calculater.TwoArguments
{

    public class GeometricMean : ITwoArgumentsCalculator
    {
        /// <summary>
        /// this method find geometric mean of two arguments
        /// </summary>
        /// <param name="firstElement"></param>
        /// <param name="secondElement"></param>
        /// <returns></returns>
        public double Calculate(double firstElement, double secondElement)
        {
            if(firstElement * secondElement<0) throw new Exception("отрицательное значение под корнем ");
            return Math.Sqrt(firstElement * secondElement);
        }
    }
}
