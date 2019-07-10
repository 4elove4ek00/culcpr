using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class OneArgumentsFactory
    {
        public static IoneArgument CreateCalculator(string sender)
        {
            switch (sender)
            {
                case "root":
                    return new Root();
                case
                    "squaring":
                    return new Squring();
                default:
                    throw new Exception("Неизвестная ошибка");
            }
        }
    }
}
