using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    [TestFixture]
    public class ArccosTests
    {
        [TestCase(1,0)]
        [TestCase(-1,3.14)]
        [TestCase(0,3.14/2)]
        public void CalculationTest(
            double FirstElement,
            double expected)
        {
            var calculator = new WindowsFormsApp1.Class.Arccos();
            var actualResult = calculator.OneCalculate(FirstElement);
            Assert.AreEqual(expected, actualResult,0.01);
        }

        [Test]
        public void WindowsFormsApp1()
        {
            var calculator = new WindowsFormsApp1.Class.Arccos();
           // var actual = calculator.OneCalculate(-10);
            Assert.Throws<Exception>(()=> calculator.OneCalculate(-10));
        }
    }
}
