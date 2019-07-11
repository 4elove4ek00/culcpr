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
            if (SecondElement == 0) throw new Exception("Неизвестная ошибка");
            return (int)(FirstElement / SecondElement);
        }
    }
}
