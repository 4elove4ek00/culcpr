using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    class TanTests
    {
        [TestCase(1, 1.55)]
        [TestCase(-1, -1.55)]
        [TestCase(0, 0)]
        public void Calcpr(
            double FirstElement,
            double expected)
        {
            var calculator = new Calcpr.Class.Tan();
            var actualResult = calculator.OneCalculate(FirstElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
