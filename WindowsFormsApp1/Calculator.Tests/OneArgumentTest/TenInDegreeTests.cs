using Calculater.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    class TenInDegreeTests
    {
        [TestCase(1, 10)]
        [TestCase(2, 100)]
        [TestCase(3, 1000)]
        public void Calcpr(
            double firstElement,
            double expected)
        {
            var calculator = new TenInDegree();
            var actualResult = calculator.OneCalculate(firstElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
