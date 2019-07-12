using Calculater.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    class LnTests
    {
        [TestCase(1, 0)]
        [TestCase(50, 3.91)]
        [TestCase(90, 4.49)]
        public void Calcpr(
            double firstElement,
            double expected)
        {
            var calculator = new Ln();
            var actualResult = calculator.OneCalculate(firstElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
