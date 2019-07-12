using System;
namespace Calcpr
{
    public class Addition : ITwoArgumentsCalculator

    {
        /// <summary>
        /// this method add together two arguments
        /// </summary>
        /// <param name="FirstElement"></param>
        /// <param name="SecondElement"></param>
        /// <returns></returns>
        public double Calculate(double FirstElement, double SecondElement)
        {
            double result = FirstElement + SecondElement;
            return result;
        }
    }
}
