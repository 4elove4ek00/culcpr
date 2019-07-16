using System;
using Calculater.OneArgument;

namespace Calculater.TwoArguments
{
   
    public class TenInDegree : IOneArgument
    {
        /// <summary>
        /// It`s search 10 in pow [First number]
        /// </summary>
        /// <param name="firstElement">First number</param>
        /// <returns></returns>
        public double OneCalculate(double firstElement)
        {
            double result = Math.Pow(10, firstElement);
            return result;
        }
    }
}
