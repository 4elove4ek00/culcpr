using System;
using Calculater.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    class GeometricMeanTests
    {

        [TestCase(4, 4, 4)]
        [TestCase(5, 5, 5)]
        [TestCase(6, 6, 6)]
        public void Calcpr(
            double firstElement,
            double secondElement,
            double expected)
        {
            var calculator = new GeometricMean();
            var actualResult = calculator.Calculate(firstElement, secondElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
        [Test]
        public void Exception()
        {
            var calculator = new GeometricMean();
            Assert.Throws<Exception>(() => calculator.Calculate(-10,10));
        }
    }
}
