using System;
namespace Calcpr.Class
{
    public class Negatively :IoneArgument
    {
        /// <summary>
        /// this method reverse argument
        /// </summary>
        /// <param name="FirstElement"></param>
        /// <returns></returns>
        public double OneCalculate(double FirstElement)
        {
            double result = 0-FirstElement;
            return result;
        }
    }
}
