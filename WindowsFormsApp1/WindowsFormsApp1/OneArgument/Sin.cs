using System;

namespace Calculater.OneArgument
{
   public class Sin : IOneArgument
    {
        /// <summary>
        /// this method Sin argument
        /// </summary>
        /// <param name="firstElement"></param>
        /// <returns></returns>
        public double OneCalculate(double firstElement)
        {
            double result = Math.Sin(  firstElement );
            return result;
        }
    }
}
