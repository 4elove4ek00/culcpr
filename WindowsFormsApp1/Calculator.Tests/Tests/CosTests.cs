using Calculater.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    public class CosTests
    {
        [TestCase(1, 0.54)]
        [TestCase(-1, 0.54)]
        [TestCase(0, 1)]
        public void Calcpr(
            double firstElement,
            double expected)
        {
            var calculator = new Cos();
            var actualResult = calculator.OneCalculate(firstElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
