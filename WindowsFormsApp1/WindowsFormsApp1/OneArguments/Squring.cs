using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcpr
{
    public class Squring : IoneArgument
    {
        /// <summary>
        /// this method squaring argument
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double OneCalculate(double FirstElement)
        {
            double result = FirstElement * FirstElement;
            return result;
        }
    }
}
