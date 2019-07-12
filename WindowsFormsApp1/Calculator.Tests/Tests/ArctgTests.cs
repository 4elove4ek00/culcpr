using Calculater.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    public class ArctgTests
    {
        [TestCase(1, 3.14 / 4)]
        [TestCase(-1, -3.14 / 4)]
        [TestCase(0, 0)]
        public void Calcpr(
            double firstElement,
            double expected)
        {
            var calculator = new Arctg();
            var actualResult = calculator.OneCalculate(firstElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
