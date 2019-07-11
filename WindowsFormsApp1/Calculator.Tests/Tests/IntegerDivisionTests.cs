using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    class IntegerDivisionTests
    {
        [TestCase(39, 6, 6)]
        [TestCase(26, 5, 5)]
        [TestCase(50, 7, 7)]
        public void WindowsFormsApp1(
            double FirstElement,
            double SecondElement,
            double expected)
        {
            var calculator = new WindowsFormsApp1.Class.IntegerDivision();
            var actualResult = calculator.Calculate(FirstElement, SecondElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
