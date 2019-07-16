using Calculater.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    class IntegerDivisionTests
    {
        [TestCase(39, 6, 6)]
        [TestCase(26, 5, 5)]
        [TestCase(50, 7, 7)]
        public void Calcpr(
            double firstElement,
            double secondElement,
            double expected)
        {
            var calculator = new IntegerDivision();
            var actualResult = calculator.Calculate(firstElement, secondElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
