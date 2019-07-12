using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    class SinTests
    {
        [TestCase(1, 0.84)]
        [TestCase(-1, -0.84)]
        [TestCase(0, 0)]
        public void Calcpr(
            double FirstElement,
            double expected)
        {
            var calculator = new Calcpr.Class.Sin();
            var actualResult = calculator.OneCalculate(FirstElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
