using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Class
{
    class TenInDegree : IoneArgument
    {
        public double OneCalculate(double FirstElement)
        {
            double result = Math.Pow(10,FirstElement);
            return result;
        }
    }
}
