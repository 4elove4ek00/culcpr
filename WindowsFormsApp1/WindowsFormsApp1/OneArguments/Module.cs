using System;
namespace Calcpr.Class
{
    public class Module : IoneArgument
    {
        /// <summary>
        /// this method of finding only positive values of argument
        /// 
        /// </summary>
        /// <param name="FirstElement"></param>
        /// <returns></returns>
        public double OneCalculate(double FirstElement)
        {
            double result = Math.Abs(FirstElement);
            return result;
        }
    }
}
