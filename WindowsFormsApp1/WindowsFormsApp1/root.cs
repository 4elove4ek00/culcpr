using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Root : IoneArgument
    {
        public double OneCalculate(double FirstElement)
        {
            double result = Math.Sqrt(FirstElement);
            return result;
        }
    }
}
