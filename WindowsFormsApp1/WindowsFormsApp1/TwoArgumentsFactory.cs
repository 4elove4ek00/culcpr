using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string sender)
        {
            switch(sender)
                {
                case "Addition":
                    return new Addition();
                case
                    "Division":
                    return new Division();
                case
                    "Multiplication":
                    return new Multiplication();
                case
                    "Subtraction":
                    return new Subtraction();
                default:
                    throw new Exception("Неизвестная ошибка");
            }
        }
    }
}
