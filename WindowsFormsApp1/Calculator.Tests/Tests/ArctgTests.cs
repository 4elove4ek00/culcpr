using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    public class ArctgTests
    {
        [TestCase(1, 3.14 / 4)]
        [TestCase(-1, -3.14 / 4)]
        [TestCase(0, 0)]
        public void WindowsFormsApp1(
            double FirstElement,
            double expected)
        {
            var calculator = new WindowsFormsApp1.Class.Arctg();
            var actualResult = calculator.OneCalculate(FirstElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
