using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    public class ArctgTests
    {
        [TestCase(1, 3.14 / 4)]
        [TestCase(-1, -3.14 / 4)]
        [TestCase(0, 0)]
        public void Calcpr(
            double FirstElement,
            double expected)
        {
            var calculator = new Calcpr.Class.Arctg();
            var actualResult = calculator.OneCalculate(FirstElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
