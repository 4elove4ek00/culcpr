using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;
using NUnit.Framework;

namespace Calculator.Tests.Tests

{
    [TestFixture]
    public class SquringTest
    {
        [Test]
        public void WindowsFormsApp1()
        {
            var calculator = new WindowsFormsApp1.Squring();
            var actual = calculator.OneCalculate(9);
            Assert.AreEqual(81, actual);
        }
    }
}


