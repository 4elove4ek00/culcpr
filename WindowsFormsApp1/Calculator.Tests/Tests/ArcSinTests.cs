using System;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    public class ArcsinTests
    {
        [TestCase(1, 3.14/2)]
        [TestCase(-1, -3.14/2)]
        [TestCase(0,0)]
        public void Calcpr(
            double FirstElement,
            double expected)
        {
            var calculator = new Calcpr.Class.Arcsin();
            var actualResult = calculator.OneCalculate(FirstElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
        [Test]
        public void Exception()
        {
            var calculator = new Calcpr.Class.Arcsin();
            Assert.Throws<Exception>(() => calculator.OneCalculate(-10));
        }
    }
}
