using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Division : ITwoArgumentsCalculator
    {
        public double Culculate(double FirstElement, double SecondElement)
        {
            double result = FirstElement / SecondElement;
            return result;
        }
    }
}
