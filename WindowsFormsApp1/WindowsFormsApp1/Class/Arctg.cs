using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Class
{
    class Arctg : IoneArgument
    {
        public double OneCalculate(double FirstElement)
        {
            double result = Math.Atan(FirstElement);
            return result;
        }
    }
}
