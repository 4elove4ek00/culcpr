using System;

namespace Calculater.OneArgument
{
    public class DivisionByElement : IOneArgument
    {
        /// <summary>
        /// this method 1/argument
        /// </summary>
        /// <param name="firstElement"></param>
        /// <returns></returns>
        public double OneCalculate(double firstElement)
        {
            if (firstElement == 0) throw new Exception("Делить на ноль нельзя!");
            double result = 1 / (firstElement);
            return result;
        }
    }
}
