using Calculater.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    [TestFixture]
    public class MultiplicationTest
    {
        [Test]
        public void Calcpr()
        {
            var calculator = new Multiplication();
            var actual = calculator.Calculate(9, 3);
            Assert.AreEqual(27, actual);
        }
    }
}
