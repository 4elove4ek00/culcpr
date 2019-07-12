using System;





namespace Calcpr
{
    public class Log : ITwoArgumentsCalculator
    {
        /// <summary>
        /// this method find log of second argument by base of first argument
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public double Calculate(double FirstElement, double SecondElement)
        {
            double result = Math.Log(FirstElement, SecondElement);
            return result;
        }
    }
}
