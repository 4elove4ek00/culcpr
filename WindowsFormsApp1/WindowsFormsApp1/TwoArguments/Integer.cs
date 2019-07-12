using System;

namespace Calculater.TwoArguments
{
   
    public class IntegerDivision : ITwoArgumentsCalculator
    {
        /// <summary>
        /// It`s search integer value
        /// </summary>
        /// <param name="firstElement">It`s first number</param>
        /// <param name="secondElement">It`s second number</param>
        /// <returns></returns>
        public double Calculate(double firstElement, double secondElement)
        {
            if (secondElement == 0D) throw new Exception("делить на 0 нельзя ");
            return (int)(firstElement / secondElement);
        }
    }
}
