using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Class;

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
                case
                    "sin":
                    return new Sin();
                case
                    "cos":
                    return new Cos();
                case
                    "tan":
                    return new Tan();
                case
                    "ln":
                    return new Ln();
                case
                    "divisionByElement":
                    return new DivisionByElement();
                case
                    "tenInDegree":
                    return new TenInDegree();
                default:
                    throw new Exception("Неизвестная ошибка");
            }
        }
    }
}
