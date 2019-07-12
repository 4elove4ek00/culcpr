using System;

namespace Calculater.OneArgument
{
    public class Cos : IOneArgument
    {
        /// <summary>
        /// this method Cos argument
        /// </summary>
        /// <param name="firstElement"></param>
        /// <returns></returns>
        public double OneCalculate(double firstElement)
        {
            double result = Math.Cos(firstElement);
            return result;
        }
    }
}
