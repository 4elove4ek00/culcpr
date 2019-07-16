using System;
using Calculater.OneArgument;
using Calculater.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.FactoryTests
{
    public class OneArgumentsFactoryTests
    {
        [TestCase("root", typeof(Root))]
        [TestCase("squaring", typeof(Squring))]
        [TestCase("sin", typeof(Sin))]
        [TestCase("cos", typeof(Cos))]
        [TestCase("tan", typeof(Tan))]
        [TestCase("ln", typeof(Ln))]
        [TestCase("divisionByElement", typeof(DivisionByElement))]
        [TestCase("tenInDegree", typeof(TenInDegree))]
        [TestCase("module", typeof(Module))]
        [TestCase("arcsin", typeof(Arcsin))]
        [TestCase("arccos", typeof(Arccos))]
        [TestCase("arctg", typeof(Arctg))]
        [TestCase("negatively", typeof(Negatively))]
        public void Calcpr(
            string name,
            Type type)
        {
            var actualResult = OneArgumentFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, actualResult);
        }
    }


}