using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Root : IoneArgument
    {
        public double OneCalculate(double FirstElement)
        {
            if(FirstElement<0) throw new Exception("Неизвестная ошибка");
            return Math.Sqrt(FirstElement);
        }
    }
}
