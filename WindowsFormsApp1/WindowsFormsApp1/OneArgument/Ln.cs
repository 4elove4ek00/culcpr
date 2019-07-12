using System;

namespace Calculater.OneArgument
{
    public class Ln : IOneArgument
    {
        /// <summary>
        /// this method find logarithm of argument by base e
        /// </summary>
        /// <param name="firstElement"></param>
        /// <returns></returns>
        public double OneCalculate(double firstElement)
        {
            double result = Math.Log(firstElement);
            return result;
        }
    }
}
