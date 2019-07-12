using System;





namespace Calcpr
{
    public class Multiplication : ITwoArgumentsCalculator
    {
        /// <summary>
        /// this method multiply two arguments
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public double Calculate(double FirstElement, double SecondElement)
        {
            double result = FirstElement * SecondElement;
            return result;
        }
    }
}
