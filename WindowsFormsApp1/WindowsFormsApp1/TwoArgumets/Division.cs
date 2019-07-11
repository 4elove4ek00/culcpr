using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcpr
{
    public class Division : ITwoArgumentsCalculator
    {
        public double Calculate(double FirstElement, double SecondElement)
        {
            if (SecondElement == 0) throw new Exception("Неизвестная ошибка");
          return FirstElement / SecondElement;
        }
    }
}
