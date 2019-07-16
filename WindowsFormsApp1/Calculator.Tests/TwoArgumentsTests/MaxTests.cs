using Calculater.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    [TestFixture]
    public class MaxTests
    {
        [TestCase(60, 30, 60)]
        [TestCase(90, 30, 90)]
        [TestCase(10, 40, 40)]
        public void Calcpr(
            double firstElement,
            double secondElement,
            double expected)
        {
            var calculator = new Max();
            var actualResult = calculator.Calculate(firstElement, secondElement);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
