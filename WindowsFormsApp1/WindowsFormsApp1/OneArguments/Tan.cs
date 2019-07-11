using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcpr.Class
{
    public class Tan : IoneArgument
    {
        public double OneCalculate(double FirstElement)
        {
            if (FirstElement == 3.14 ) throw new Exception("недопустимое значение ");
            return Math.Tan(FirstElement); ;
        }
    }
}
