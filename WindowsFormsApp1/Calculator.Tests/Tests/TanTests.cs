using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    class TanTests
    {
        [TestCase(1, 1.55)]
        [TestCase(-1, -1.55)]
        [TestCase(0, 0)]
        public void WindowsFormsApp1(
            double FirstElement,
            double expected)
        {
            var calculator = new WindowsFormsApp1.Class.Tan();
            var actualResult = calculator.OneCalculate(FirstElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
