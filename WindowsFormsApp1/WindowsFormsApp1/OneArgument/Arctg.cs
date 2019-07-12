using System;

namespace Calculater.OneArgument
{
    public class Arctg : IOneArgument
    {
        /// <summary>
        /// this method Arctan argument
        /// </summary>
        /// <param name="firstElement">It`s first element </param>
        /// <returns></returns>
        public double OneCalculate(double firstElement)
        {
            return Math.Atan(firstElement);
        }
    }
}
