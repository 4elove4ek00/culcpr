using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    class LogTests
    {
        [TestCase(1, 3, 0)]
        [TestCase(9, 3, 2)]
        [TestCase(25, 5, 2)]
        public void Calcpr(
            double FirstElement,
            double SecondElement,
            double expected)
        {
            var calculator = new Calcpr.Log();
            var actualResult = calculator.Calculate(FirstElement, SecondElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
