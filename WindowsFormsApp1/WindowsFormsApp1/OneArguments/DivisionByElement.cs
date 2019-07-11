using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcpr.Class
{
    public class DivisionByElement : IoneArgument
    {
        /// <summary>
        /// this method 1/argument
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double OneCalculate(double FirstElement)
        {
            if (FirstElement == 0) throw new Exception("Делить на ноль нельзя!");
            double result = 1 / (FirstElement);
            return result;
        }
    }
}
