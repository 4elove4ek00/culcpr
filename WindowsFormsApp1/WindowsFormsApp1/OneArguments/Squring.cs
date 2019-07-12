using System;
namespace Calcpr
{
    public class Squring : IoneArgument
    {
        /// <summary>
        /// this method squaring argument
        /// </summary>
        /// <param name="FirstElement"></param>
        /// <returns></returns>
        public double OneCalculate(double FirstElement)
        {
            double result = FirstElement * FirstElement;
            return result;
        }
    }
}
