using System;
namespace Calcpr.Class
{
    public class Cos : IoneArgument
    {
        /// <summary>
        /// this method Cos argument
        /// </summary>
        /// <param name="FirstElement"></param>
        /// <returns></returns>
        public double OneCalculate(double FirstElement)
        {
            double result = Math.Cos(FirstElement);
            return result;
        }
    }
}
