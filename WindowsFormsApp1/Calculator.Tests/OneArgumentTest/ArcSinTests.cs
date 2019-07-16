using System;
using Calculater.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    public class ArcsinTests
    {
        [TestCase(1, 3.14/2)]
        [TestCase(-1, -3.14/2)]
        [TestCase(0,0)]
        public void Calcpr(
            double firstElement,
            double expected)
        {
            var calculator = new Arcsin();
            var actualResult = calculator.OneCalculate(firstElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
        [Test]
        public void Exception()
        {
            var calculator = new Arcsin();
            Assert.Throws<Exception>(() => calculator.OneCalculate(-10));
        }
    }
}
