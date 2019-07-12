using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    [TestFixture]
    public class MinTests
    {
        [TestCase(60, 30, 30)]
        [TestCase(90, 30, 30)]
        [TestCase(10, 40, 10)]
        public void Calcpr(
            double FirstElement,
            double SecondElement,
            double expected)
        {
            var calculator = new Calcpr.Class.Min();
            var actualResult = calculator.Calculate(FirstElement, SecondElement);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
