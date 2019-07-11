﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcpr.Class
{
    
    public class Min : ITwoArgumentsCalculator
    {
        /// <summary>
        /// this method find min argument
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public double Calculate(double FirstElement, double SecondElement)
        {
            double result = Math.Min(FirstElement, SecondElement);
            return result;
        }
    }
}