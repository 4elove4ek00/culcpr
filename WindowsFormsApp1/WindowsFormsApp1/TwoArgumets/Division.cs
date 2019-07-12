using System;
namespace Calcpr
{
   
    public class Division : ITwoArgumentsCalculator
    {
        /// <summary>
        /// It`s search division 2 numbers
        /// </summary>
        /// <param name="FirstElement">First number</param>
        /// <param name="SecondElement">Second number</param>
        /// <returns></returns>
        public double Calculate(double FirstElement, double SecondElement)
        {
            if (SecondElement == 0) throw new Exception("делить на 0 нельзя!");
          return FirstElement / SecondElement;
        }
    }
}
