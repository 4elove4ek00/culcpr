using System;

namespace Calculater.TwoArguments
{
   
    public class Division : ITwoArgumentsCalculator
    {
        /// <summary>
        /// It`s search division 2 numbers
        /// </summary>
        /// <param name="firstElement">First number</param>
        /// <param name="secondElement">Second number</param>
        /// <returns></returns>
        public double Calculate(double firstElement, double secondElement)
        {
            if (secondElement == 0D) throw new Exception("делить на 0 нельзя!");
          return firstElement / secondElement;
        }
    }
}
