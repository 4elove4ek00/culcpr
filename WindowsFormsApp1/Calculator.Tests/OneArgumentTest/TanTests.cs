using Calculater.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    class TanTests
    {
        [TestCase(1, 1.55)]
        [TestCase(-1, -1.55)]
        [TestCase(0, 0)]
        public void Calcpr(
            double firstElement,
            double expected)
        {
            var calculator = new Tan();
            var actualResult = calculator.OneCalculate(firstElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
