using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Class
{
    class Arccos : IoneArgument
    {
        public double OneCalculate(double FirstElement)
        {
            double result = Math.Acos(FirstElement);
            return result;
        }
    }
}
