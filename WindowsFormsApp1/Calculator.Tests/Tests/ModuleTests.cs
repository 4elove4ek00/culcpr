using Calculater.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    class ModuleTests
    {
        [TestCase(1, 1)]
        [TestCase(-9,9)]
        [TestCase(25, 25)]
        public void Calcpr(
            double firstElement,
           double expected)
        {
            var calculator = new Module();
            var actualResult = calculator.OneCalculate(firstElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
