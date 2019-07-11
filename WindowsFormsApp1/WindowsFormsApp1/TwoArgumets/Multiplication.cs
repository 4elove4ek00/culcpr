using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcpr
{/// <summary>
/// Class for Multiplication
/// </summary>
    public class Multiplication : ITwoArgumentsCalculator
    {
        /// <summary>
        /// It`s search multiplication 2 numbers
        /// </summary>
        /// <param name="FirstElement"></param>
        /// <param name="SecondElement"></param>
        /// <returns></returns>
        public double Calculate(double FirstElement, double SecondElement)
        {
            double result = FirstElement * SecondElement;
            return result;
        }
    }
}
