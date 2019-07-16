using System;
using Calculater.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    [TestFixture]
    public class RootTest
    {
        [Test]
        public void Calcpr()
        {
            var calculator = new Root();
            var actual = calculator.OneCalculate(9);
            Assert.AreEqual(3, actual);
        }
        [Test]
        public void Exception()
        {
            var calculator = new Root();
            Assert.Throws<Exception>(() => calculator.OneCalculate(-10));
        }
    }
}
