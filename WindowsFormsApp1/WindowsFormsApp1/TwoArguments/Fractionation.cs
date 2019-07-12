using System;

namespace Calculater.TwoArguments
{
    
    public class Fractionation: ITwoArgumentsCalculator
    {
        /// <summary>
    /// It`s search first number in pow (1/second number)
    /// </summary>
    /// <param name="firstElement">First number</param>
    /// <param name="secondElement">Second number</param>
    /// <returns></returns>
        public double Calculate(double firstElement, double secondElement)
        {
            double result = Math.Pow (firstElement, (1/secondElement));
            return result;
        }
    }
}
