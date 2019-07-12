using System;
namespace Calcpr.Class
{
    public class Ln : IoneArgument
    {
        /// <summary>
        /// this method find logarithm of argument by base e
        /// </summary>
        /// <param name="FirstElement"></param>
        /// <returns></returns>
        public double OneCalculate(double FirstElement)
        {
            double result = Math.Log(FirstElement);
            return result;
        }
    }
}
