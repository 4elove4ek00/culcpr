using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcpr.Class
{
    public class Module: IoneArgument
    {
        /// <summary>
        /// this method of finding only positive values of argument
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double OneCalculate(double FirstElement)
        {
            double result = Math.Abs(FirstElement);
            return result;
        }
    }
}
