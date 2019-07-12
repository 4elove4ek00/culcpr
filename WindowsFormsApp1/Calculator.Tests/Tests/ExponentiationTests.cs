using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    class ExponentiationTests
    {
        [TestCase(1, 1, 1)]
        [TestCase(-1, 2, 1)]
        [TestCase(2, 2, 4)]
        public void Calcpr(
            double FirstElement,
            double SecondElement,
            double expected)
        {
            var calculator = new Calcpr.Class.Exponentiation();
            var actualResult = calculator.Calculate(FirstElement, SecondElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
