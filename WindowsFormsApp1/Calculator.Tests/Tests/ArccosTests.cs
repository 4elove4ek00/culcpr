using System;
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
            double FirstElement,
            double expected)
        {
            var calculator = new Calcpr.Class.Arccos();
            var actualResult = calculator.OneCalculate(FirstElement);
            Assert.AreEqual(expected, actualResult,0.01);
        }

        [Test]
        public void Exception()
        {
            var calculator = new Calcpr.Class.Arccos();
            Assert.Throws<Exception>(()=> calculator.OneCalculate(-10));
        }
    }
}
