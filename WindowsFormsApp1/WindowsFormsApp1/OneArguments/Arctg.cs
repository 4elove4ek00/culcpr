using System;
namespace Calcpr.Class
{
    public class Arctg : IoneArgument
    {
        /// <summary>
        /// this method Arctan argument
        /// </summary>
        /// <param name="FirstElement">It`s first element </param>
        /// <returns></returns>
        public double OneCalculate(double FirstElement)
        {
            double result = Math.Atan(FirstElement);
            return result;
        }
    }
}
