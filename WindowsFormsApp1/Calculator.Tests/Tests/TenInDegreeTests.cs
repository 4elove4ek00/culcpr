using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    class TenInDegreeTests
    {
        [TestCase(1, 10)]
        [TestCase(2, 100)]
        [TestCase(3, 1000)]
        public void WindowsFormsApp1(
            double FirstElement,
            double expected)
        {
            var calculator = new WindowsFormsApp1.Class.TenInDegree();
            var actualResult = calculator.OneCalculate(FirstElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
