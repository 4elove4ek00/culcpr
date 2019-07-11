using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    class LnTests
    {
        [TestCase(1, 0)]
        [TestCase(50, 3.91)]
        [TestCase(90, 4.49)]
        public void WindowsFormsApp1(
            double FirstElement,
            //double SecondElement,
            double expected)
        {
            var calculator = new WindowsFormsApp1.Class.Ln();
            var actualResult = calculator.OneCalculate(FirstElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
