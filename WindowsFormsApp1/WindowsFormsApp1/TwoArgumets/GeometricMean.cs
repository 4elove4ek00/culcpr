using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcpr.Class
{

    public class GeometricMean : ITwoArgumentsCalculator
    {
        public double Calculate(double FirstElement, double SecondElement)
        {
            if(FirstElement * SecondElement<0) throw new Exception("Неизвестная ошибка");
            return Math.Sqrt(FirstElement * SecondElement);
        }
    }
}
