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
        public void WindowsFormsApp1()
        {
            var calculator = new WindowsFormsApp1.Division();
            var actual = calculator.Calculate(9,3);
            Assert.AreEqual(3, actual);
        }
    }
}