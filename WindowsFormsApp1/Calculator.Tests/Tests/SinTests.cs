using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    class SinTests
    {
        [TestCase(1, 0.84)]
        [TestCase(-1, -0.84)]
        [TestCase(0, 0)]
        public void WindowsFormsApp1(
            double FirstElement,
            double expected)
        {
            var calculator = new WindowsFormsApp1.Class.Sin();
            var actualResult = calculator.OneCalculate(FirstElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
