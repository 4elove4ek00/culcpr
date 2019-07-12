using Calculater.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.Tests

{
    [TestFixture]
    public class SquringTest
    {
        [Test]
        public void Calcpr()
        {
            var calculator = new Squring();
            var actual = calculator.OneCalculate(9);
            Assert.AreEqual(81, actual);
        }
    }
}


