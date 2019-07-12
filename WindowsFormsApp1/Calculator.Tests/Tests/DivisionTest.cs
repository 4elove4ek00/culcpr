using Calculater.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.Tests

{
    [TestFixture]
    public class DivisionTest
    {
        [Test]
        public void Calcpr()
        {
            var calculator = new Division();
            var actual = calculator.Calculate(9, 3);
            Assert.AreEqual(3, actual);
        }
    }
}