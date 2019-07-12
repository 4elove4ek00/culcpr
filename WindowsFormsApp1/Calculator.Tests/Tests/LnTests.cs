using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    class LnTests
    {
        [TestCase(1, 0)]
        [TestCase(50, 3.91)]
        [TestCase(90, 4.49)]
        public void Calcpr(
            double FirstElement,
            double expected)
        {
            var calculator = new Calcpr.Class.Ln();
            var actualResult = calculator.OneCalculate(FirstElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
