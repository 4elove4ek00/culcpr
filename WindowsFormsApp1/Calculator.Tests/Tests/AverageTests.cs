using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    public class AverageTests
    {
        [TestCase(2,2,2)]
        [TestCase(100,50,75)]
        [TestCase(0,2,1)]
        public void Calcpr(
            double FirstElement,
            double SecondElement,
                double expected)
        {
            var calculator = new Calcpr.Class.Average();
            var actualResult = calculator.Calculate(FirstElement,SecondElement);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
