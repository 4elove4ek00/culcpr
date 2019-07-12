using System;
namespace Calcpr.Class
{
    public class Max : ITwoArgumentsCalculator
    {
        /// <summary>
        /// this method find max argument
        /// </summary>
        /// <param name="FirstElement"></param>
        /// <param name="SecondElement"></param>
        /// <returns></returns>
        public double Calculate(double FirstElement, double SecondElement)
        {
            double result = Math.Max(FirstElement, SecondElement);
            return result;
        }
    }
}
