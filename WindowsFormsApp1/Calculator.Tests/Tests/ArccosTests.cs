using System;
using Calculater.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    [TestFixture]
    public class ArccosTests
    {
        [TestCase(1,0)]
        [TestCase(-1,3.14)]
        [TestCase(0,3.14/2)]
        public void CalculationTest(
            double firstElement,
            double expected)
        {
            var calculator = new Arccos();
            var actualResult = calculator.OneCalculate(firstElement);
            Assert.AreEqual(expected, actualResult,0.01);
        }

        [Test]
        public void Exception()
        {
            var calculator = new Arccos();
            Assert.Throws<Exception>(()=> calculator.OneCalculate(-10));
        }
    }
}
