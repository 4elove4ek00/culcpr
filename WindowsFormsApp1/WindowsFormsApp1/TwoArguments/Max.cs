using System;

namespace Calculater.TwoArguments
{
    public class Max : ITwoArgumentsCalculator
    {
        /// <summary>
        /// this method find max argument
        /// </summary>
        /// <param name="firstElement"></param>
        /// <param name="secondElement"></param>
        /// <returns></returns>
        public double Calculate(double firstElement, double secondElement)
        {
            double result = Math.Max(firstElement, secondElement);
            return result;
        }
    }
}
