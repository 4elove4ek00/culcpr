using System;
namespace Calcpr.Class
{
   public class Sin : IoneArgument
    {
        /// <summary>
        /// this method Sin argument
        /// </summary>
        /// <param name="FirstElement"></param>
        /// <returns></returns>
        public double OneCalculate(double FirstElement)
        {
            double result = Math.Sin(  FirstElement );
            return result;
        }
    }
}
