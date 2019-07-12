using System;

namespace Calculater.OneArgument
{
    public class Root : IOneArgument
    {
        /// <summary>
        /// this method find square root of argument
        /// </summary>
        /// <param name="firstElement"></param>
        /// <returns></returns>
        public double OneCalculate(double firstElement)
        {
            if(firstElement<0) throw new Exception("отрицательное значение под корнем ");
            return Math.Sqrt(firstElement);
        }
    }
}
