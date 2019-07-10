using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Class
{
    public class IntegerDivision : ITwoArgumentsCalculator
    {
        public double Calculate(double FirstElement, double SecondElement)
        {
            int result = (int)(FirstElement/SecondElement);
            return result;
        }
    }
}
