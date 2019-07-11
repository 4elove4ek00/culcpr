using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcpr
{/// <summary>
/// Class for Log
/// </summary>
    public class Log : ITwoArgumentsCalculator
    {
        /// <summary>
        /// It`s search log value of 2 numbers
        /// </summary>
        /// <param name="FirstElement"> First number</param>
        /// <param name="SecondElement">Second number</param>
        /// <returns></returns>
        public double Calculate(double FirstElement, double SecondElement)
        {
            double result = Math.Log(FirstElement, SecondElement);
            return result;
        }
    }
}
