using Calculater.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    public class AverageTests
    {
        [TestCase(2, 2, 2)]
        [TestCase(100, 50, 75)]
        [TestCase(0, 2, 1)]
        public void Calcpr(
            double firstElement,
            double secondElement,
                double expected)
        {
            var calculator = new Average();
            var actualResult = calculator.Calculate(firstElement, secondElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
