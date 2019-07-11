using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcpr
{
    public class Root : IoneArgument
    {
        public double OneCalculate(double FirstElement)
        {
            if(FirstElement<0) throw new Exception("отрицательное значение под корнем ");
            return Math.Sqrt(FirstElement);
        }
    }
}
