using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    class GeometricMeanTests
    {

        [TestCase(4, 4, 4)]
        [TestCase(5, 5, 5)]
        [TestCase(6, 6, 6)]
        public void WindowsFormsApp1(
            double FirstElement,
            double SecondElement,
            double expected)
        {
            var calculator = new WindowsFormsApp1.Class.GeometricMean();
            var actualResult = calculator.Calculate(FirstElement, SecondElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
