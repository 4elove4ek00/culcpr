using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;
using WindowsFormsApp1.Class;
using NUnit.Framework;

namespace Calculator.Tests.FactoryTests
{
   public class TwoArgumentsFactoryTests
    {
        [TestCase("Addition", typeof(Addition))]
        [TestCase("Division", typeof(Division))]
        [TestCase("Multiplication", typeof(Multiplication))]
        [TestCase("Subtraction", typeof(Subtraction))]
        [TestCase("Average", typeof(Average))]
        [TestCase("Remainder", typeof(Remainder))]
        [TestCase("fractionation", typeof(Fractionation))]
        [TestCase("max", typeof(Max))]
        [TestCase("min", typeof(Min))]
        [TestCase("geometricMean", typeof(GeometricMean))]
        [TestCase("exponentiation", typeof(Exponentiation))]
        [TestCase("log", typeof(Log))]
        [TestCase("IntegerDivision", typeof(IntegerDivision))]
        public void WindowsFormsApp1(
            string name,
            Type type)
        {
            var actualResult = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, actualResult);
        }
    }


}
