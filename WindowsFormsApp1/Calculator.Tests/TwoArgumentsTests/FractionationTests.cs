using Calculater.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    class FractionationTests
    {
        [TestCase(4, 2, 2)]
        [TestCase(9, 2, 3)]
        [TestCase(0, 3, 0)]
        public void Calcpr(
            double firstElement,
            double secondElement,
            double expected)
        {
            var calculator = new Fractionation();
            var actualResult = calculator.Calculate(firstElement, secondElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
