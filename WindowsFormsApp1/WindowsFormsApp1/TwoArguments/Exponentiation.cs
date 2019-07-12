using System;

namespace Calculater.TwoArguments
{
    
    public class Exponentiation : ITwoArgumentsCalculator
    {
        /// <summary>
        /// It`s search pow 2 numbers
        /// </summary>
        /// <param name="firstElement">First number</param>
        /// <param name="secondElement">Second number</param>
        /// <returns></returns>
        public double Calculate(double firstElement, double secondElement)
        {
            double result = Math.Pow(firstElement, secondElement);
            return result;
        }
    }
}
