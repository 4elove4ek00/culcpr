using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    [TestFixture]
    public class SubstractionTest
    {
        [Test]
        public void Calcpr()
        {
            var calculator = new Calcpr.Subtraction();
            var actual = calculator.Calculate(9, 3);
            Assert.AreEqual(6, actual);
        }
    }
}
