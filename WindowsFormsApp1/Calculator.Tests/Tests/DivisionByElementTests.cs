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
        public void Calcpr(
            double FirstElement,
            double expected)
        {
            var calculator = new Calcpr.Class.DivisionByElement();
            var actualResult = calculator.OneCalculate(FirstElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
        [Test]
        public void Exception()
        {
            var calculator = new Calcpr.Class.DivisionByElement();
            Assert.Throws<Exception>(() => calculator.OneCalculate(0));
        }
    }
}
