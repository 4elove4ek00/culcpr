using Calculater.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    class ExponentiationTests
    {
        [TestCase(1, 1, 1)]
        [TestCase(-1, 2, 1)]
        [TestCase(2, 2, 4)]
        public void Calcpr(
            double firstElement,
            double secondElement,
            double expected)
        {
            var calculator = new Exponentiation();
            var actualResult = calculator.Calculate(firstElement, secondElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
