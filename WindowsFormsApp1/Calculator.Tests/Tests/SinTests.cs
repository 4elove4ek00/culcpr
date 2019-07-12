using Calculater.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    class SinTests
    {
        [TestCase(1, 0.84)]
        [TestCase(-1, -0.84)]
        [TestCase(0, 0)]
        public void Calcpr(
            double firstElement,
            double expected)
        {
            var calculator = new Sin();
            var actualResult = calculator.OneCalculate(firstElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
