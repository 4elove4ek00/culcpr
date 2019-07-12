using System;
namespace Calcpr.Class
{
    public class Tan : IoneArgument
    {
        /// <summary>
        /// this method Tan argument
        /// </summary>
        /// <param name="FirstElement"></param>
        /// <returns></returns>
        public double OneCalculate(double FirstElement)
        {
            if (FirstElement == 3.14 ) throw new Exception("недопустимое значение ");
            return Math.Tan(FirstElement); ;
        }
    }
}
