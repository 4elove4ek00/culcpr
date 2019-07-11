using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcpr.Class
{
    public class Arctg : IoneArgument
    {
        public double OneCalculate(double FirstElement)
        {
            double result = Math.Atan(FirstElement);
            return result;
        }
    }
}
