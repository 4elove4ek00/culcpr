using NUnit.Framework;

namespace Calculator.Tests.Tests

{
    [TestFixture]
    public class SquringTest
    {
        [Test]
        public void Calcpr()
        {
            var calculator = new Calcpr.Squring();
            var actual = calculator.OneCalculate(9);
            Assert.AreEqual(81, actual);
        }
    }
}


