using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcpr.Class
{
    public class Ln : IoneArgument
    {
        /// <summary>
        /// this method find logarithm of argument by base e
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double OneCalculate(double FirstElement)
        {
            double result = Math.Log(FirstElement);
            return result;
        }
    }
}
