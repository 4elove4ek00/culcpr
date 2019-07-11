using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Class
{
    public class DivisionByElement : IoneArgument
    {
        public double OneCalculate(double FirstElement)
        {
            double result = 1 / (FirstElement);
            return result;
        }
    }
}
