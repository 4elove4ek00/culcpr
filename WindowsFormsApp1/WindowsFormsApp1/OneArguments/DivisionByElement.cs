using System;
namespace Calcpr.Class
{
    public class DivisionByElement : IoneArgument
    {
        /// <summary>
        /// this method 1/argument
        /// </summary>
        /// <param name="FirstElement"></param>
        /// <returns></returns>
        public double OneCalculate(double FirstElement)
        {
            if (FirstElement == 0) throw new Exception("Делить на ноль нельзя!");
            double result = 1 / (FirstElement);
            return result;
        }
    }
}
