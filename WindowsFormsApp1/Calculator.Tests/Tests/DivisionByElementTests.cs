using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
     public class DivisionByElementTests
    {
        [TestCase(1, 1)]
        [TestCase(-1, -1)]
        [TestCase(2, 0.5)]
        public void WindowsFormsApp1(
            double FirstElement,
            double expected)
        {
            var calculator = new WindowsFormsApp1.Class.DivisionByElement();
            var actualResult = calculator.OneCalculate(FirstElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
