using System;

namespace Calculater.TwoArguments
{
    
    public class Min : ITwoArgumentsCalculator
    {
        /// <summary>
        /// this method find min argument
        /// </summary>
        /// <param name="firstElement"></param>
        /// <param name="secondElement"></param>
        /// <returns></returns>
        public double Calculate(double firstElement, double secondElement)
        {
            double result = Math.Min(firstElement, secondElement);
            return result;
        }
    }
}
