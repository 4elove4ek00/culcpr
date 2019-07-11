using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcpr.Class
{
    /// <summary>
    /// Class for Min
    /// </summary>
    public class Min : ITwoArgumentsCalculator
    {/// <summary>
     /// It`s search minimum value of 2 numbers
     /// </summary>
     /// <param name="FirstElement"></param>
     /// <param name="SecondElement"></param>
     /// <returns></returns>
        public double Calculate(double FirstElement, double SecondElement)
        {
            double result = Math.Min(FirstElement, SecondElement);
            return result;
        }
    }
}
