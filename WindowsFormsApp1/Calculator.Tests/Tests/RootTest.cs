using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    [TestFixture]
    public class RootTest
    {
        [Test]
        public void WindowsFormsApp1()
        {
            var calculator = new WindowsFormsApp1.Root();
            var actual = calculator.OneCalculate(9);
            Assert.AreEqual(3, actual);
        }
    }
}
