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
        public void Calcpr(
            double FirstElement,
            double SecondElement,
            double expected)
        {
            var calculator = new Calcpr.Class.GeometricMean();
            var actualResult = calculator.Calculate(FirstElement, SecondElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
        [Test]
        public void Exception()
        {
            var calculator = new Calcpr.Class.GeometricMean();
            Assert.Throws<Exception>(() => calculator.Calculate(-10,10));
        }
    }
}
