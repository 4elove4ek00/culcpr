using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    [TestFixture]
    public class MaxTests
    {
        [TestCase(60, 30, 60)]
        [TestCase(90, 30, 90)]
        [TestCase(10, 40, 40)]
        public void Calcpr(
            double FirstElement,
            double SecondElement,
            double expected)
        {
            var calculator = new Calcpr.Class.Max();
            var actualResult = calculator.Calculate(FirstElement, SecondElement);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
