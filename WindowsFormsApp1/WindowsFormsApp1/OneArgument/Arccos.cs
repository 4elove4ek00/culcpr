using System;

namespace Calculater.OneArgument
{
    public class Arccos : IOneArgument
    {
        /// <summary>
        /// this method Arccos argument
        /// </summary>
        /// <param name="firstElement"></param>
        /// <returns></returns>
        public double OneCalculate(double firstElement)
        {
            if ((firstElement < (-1)) || (firstElement > 1))
            {
                throw new Exception("выход за область допустимых значений  ");
            }
            return Math.Acos(firstElement);
        }
    }
}
