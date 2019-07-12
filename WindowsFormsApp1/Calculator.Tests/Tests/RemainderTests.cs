using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    class RemainderTests
    {
        [TestCase(2, 3, 2)]
        [TestCase(3, 3, 0)]
        [TestCase(4, 3, 1)]
        public void Calcpr(
            double FirstElement,
            double SecondElement,
            double expected)
        {
            var calculator = new Calcpr.Class.Remainder();
            var actualResult = calculator.Calculate(FirstElement, SecondElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
