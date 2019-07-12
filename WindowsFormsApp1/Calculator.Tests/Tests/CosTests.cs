using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    public class CosTests
    {
        [TestCase(1, 0.54)]
        [TestCase(-1, 0.54)]
        [TestCase(0, 1)]
        public void Calcpr(
            double FirstElement,
            double expected)
        {
            var calculator = new Calcpr.Class.Cos();
            var actualResult = calculator.OneCalculate(FirstElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
