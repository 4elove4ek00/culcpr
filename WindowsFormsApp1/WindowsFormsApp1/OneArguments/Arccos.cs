using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Class
{
    public class Arccos : IoneArgument
    {
        public double OneCalculate(double FirstElement)
        {
            if((FirstElement < (-1)) || (FirstElement > 1)) throw new Exception("Неизвестная ошибка");
            return Math.Acos(FirstElement);
        }
    }
}
