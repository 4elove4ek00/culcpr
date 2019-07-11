using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcpr.Class
{
   public class Sin : IoneArgument
    {
        /// <summary>
        /// this method Sin argument
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double OneCalculate(double FirstElement)
        {
            double result = Math.Sin(  FirstElement );
            return result;
        }
    }
}
