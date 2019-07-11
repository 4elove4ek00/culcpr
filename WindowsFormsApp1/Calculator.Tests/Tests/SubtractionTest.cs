using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    [TestFixture]
    public class SubstractionTest
    {
        [Test]
        public void WindowsFormsApp1()
        {
            var calculator = new WindowsFormsApp1.Subtraction();
            var actual = calculator.Calculate(9, 3);
            Assert.AreEqual(6, actual);
        }
    }
}
