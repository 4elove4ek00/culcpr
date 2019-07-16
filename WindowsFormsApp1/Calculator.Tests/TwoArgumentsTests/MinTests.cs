using Calculater.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    [TestFixture]
    public class MinTests
    {
        [TestCase(60, 30, 30)]
        [TestCase(90, 30, 30)]
        [TestCase(10, 40, 10)]
        public void Calcpr(
            double firstElement,
            double secondElement,
            double expected)
        {
            var calculator = new Min();
            var actualResult = calculator.Calculate(firstElement, secondElement);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
