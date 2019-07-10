using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Class
{
    class Fractionation: ITwoArgumentsCalculator
    {
        public double Calculate(double FirstElement, double SecondElement)
        {
            double result = Math.Pow (FirstElement, (1/SecondElement));
            return result;
        }
    }
}
