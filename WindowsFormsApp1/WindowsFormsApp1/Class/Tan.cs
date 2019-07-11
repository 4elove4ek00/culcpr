using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Class
{
    public class Tan : IoneArgument
    {
        public double OneCalculate(double FirstElement)
        {
            double result = Math.Tan(FirstElement);
            return result;
        }
    }
}
