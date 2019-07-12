using System;
using Calculater.TwoArguments;

namespace Calculater.OneArgument
{
    public class OneArgumentFactory
    {
        /// <summary>
        /// factory for working with one argument
        /// </summary>
        /// <param name="sender">It`s name keys </param>
        /// <returns></returns>
        public static IOneArgument CreateCalculator(string sender)
        {
            switch (sender)
            {
                case "root":
                    return new Root();
                case "squaring":
                    return new Squring();
                case "sin":
                    return new Sin();
                case "cos":
                    return new Cos();
                case "tan":
                    return new Tan();
                case "ln":
                    return new Ln();
                case "divisionByElement":
                    return new DivisionByElement();
                case "tenInDegree":
                    return new TenInDegree();
                case "module":
                    return new Module();
                case "arcsin":
                    return new Arcsin();
                case "arccos":
                    return new Arccos();
                case "arctg":
                    return new Arctg();
                case "negatively":
                    return new Negatively();

                default:
                    throw new Exception("Неизвестная ошибка");
            }
        }
    }
}
