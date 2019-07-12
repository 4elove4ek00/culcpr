using System;
namespace Calcpr.Class
{
    public class Arccos : IoneArgument
    {
        /// <summary>
        /// this method Arccos argument
        /// </summary>
        /// <param name="FirstElement"></param>
        /// <returns></returns>
        public double OneCalculate(double FirstElement)
        {
            if ((FirstElement < (-1)) || (FirstElement > 1)) throw new Exception("выход за область допустимых значений  ");
            return Math.Acos(FirstElement);
        }
    }
}
