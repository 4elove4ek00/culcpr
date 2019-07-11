using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Squring : IoneArgument
    {
        public double OneCalculate(double FirstElement)
        {
            double result = FirstElement * FirstElement;
            return result;
        }
    }
}
