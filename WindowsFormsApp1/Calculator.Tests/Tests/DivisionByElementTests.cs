using System;
using Calculater.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
     public class DivisionByElementTests
    {
        [TestCase(1, 1)]
        [TestCase(-1, -1)]
        [TestCase(2, 0.5)]
        public void Calcpr(
            double firstElement,
            double expected)
        {
            var calculator = new DivisionByElement();
            var actualResult = calculator.OneCalculate(firstElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
        [Test]
        public void Exception()
        {
            var calculator = new DivisionByElement();
            Assert.Throws<Exception>(() => calculator.OneCalculate(0));
        }
    }
}
