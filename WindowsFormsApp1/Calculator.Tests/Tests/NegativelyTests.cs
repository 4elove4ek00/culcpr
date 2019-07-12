using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    class NegativelyTests
    {
        [TestCase(1, -1)]
        [TestCase(-9, 9)]
        [TestCase(25, -25)]
        public void Calcpr(
            double FirstElement,
           double expected)
        {
            var calculator = new Calcpr.Class.Negatively();
            var actualResult = calculator.OneCalculate(FirstElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
