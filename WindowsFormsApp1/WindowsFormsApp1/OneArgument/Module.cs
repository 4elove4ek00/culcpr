using System;

namespace Calculater.OneArgument
{
    public class Module : IOneArgument
    {
        /// <summary>
        /// this method of finding only positive values of argument
        /// </summary>
        /// <param name="firstElement"></param>
        /// <returns></returns>
        public double OneCalculate(double firstElement)
        {
            double result = Math.Abs(firstElement);
            return result;
        }
    }
}
