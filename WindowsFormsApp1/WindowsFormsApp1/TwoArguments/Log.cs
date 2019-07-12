using System;

namespace Calculater.TwoArguments
{
    public class Log : ITwoArgumentsCalculator
    {
        /// <summary>
        /// this method find log of second argument by base of first argument
        /// </summary>
        /// <param name="firstElement"></param>
        /// <param name="secondElement"></param>
        /// <returns></returns>
        public double Calculate(double firstElement, double secondElement)
        {
            double result = Math.Log(firstElement, secondElement);
            return result;
        }
    }
}
