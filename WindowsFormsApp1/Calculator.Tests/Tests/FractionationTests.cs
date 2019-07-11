using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    class FractionationTests
    {
        [TestCase(4, 2, 2)]
        [TestCase(9, 2, 3)]
        [TestCase(0, 3, 0)]
        public void WindowsFormsApp1(
            double FirstElement,
            double SecondElement,
            double expected)
        {
            var calculator = new WindowsFormsApp1.Class.Fractionation();
            var actualResult = calculator.Calculate(FirstElement, SecondElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
