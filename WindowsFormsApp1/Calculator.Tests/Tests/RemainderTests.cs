using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    class RemainderTests
    {
        [TestCase(2,3,2)]
        [TestCase(3,3,0)]
        [TestCase(4, 3,1)]
        public void WindowsFormsApp1(
            double FirstElement,
            double SecondElement,
            double expected)
        {
            var calculator = new WindowsFormsApp1.Class.Remainder();
            var actualResult = calculator.Calculate(FirstElement,SecondElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
