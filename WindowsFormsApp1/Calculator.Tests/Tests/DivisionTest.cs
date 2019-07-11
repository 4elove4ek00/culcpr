using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Calculator.Tests.Tests

{
    [TestFixture]
    public class DivisionTest
    {
        [Test]
        public void Calcpr()
        {
            var calculator = new Calcpr.Division();
            var actual = calculator.Calculate(9,3);
            Assert.AreEqual(3, actual);
        }
    }
}