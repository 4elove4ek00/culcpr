using System;

namespace Calculater.OneArgument
{
    public class Tan : IOneArgument
    {
        /// <summary>
        /// this method Tan argument
        /// </summary>
        /// <param name="firstElement"></param>
        /// <returns></returns>
        public double OneCalculate(double firstElement)
        {
            if (firstElement == Math.PI ) throw new Exception("недопустимое значение ");
            return Math.Tan(firstElement); ;
        }
    }
}
