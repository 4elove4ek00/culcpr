using Calculater.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    class RemainderTests
    {
        [TestCase(2, 3, 2)]
        [TestCase(3, 3, 0)]
        [TestCase(4, 3, 1)]
        public void Calcpr(
            double firstElement,
            double secondElement,
            double expected)
        {
            var calculator = new Remainder();
            var actualResult = calculator.Calculate(firstElement, secondElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
