using System;
using NUnit.Framework;
using CalcLibrary;

namespace CalcLibraryTest
{
    [TestFixture]
    public class CalculatorTests
    {
        SimpleCalculator p;
        private double result;
        [SetUp]
        public void SetUp()
        {
            p = new SimpleCalculator();
        }
        [TearDown]
        public void TearDown()
        {
            p = null;
        }
        [TestCase]
        public void SubstractionTestcase1()
        {
            double ares = p.Subtraction(30, 20);
            double eres = 10;
            Assert.That(ares, Is.EqualTo(eres));
        }
        [TestCase]
        public void SubstractionTestcase2()
        {
            double ares = p.Subtraction(20, 30);
            double eres = -10;
            Assert.That(ares, Is.EqualTo(eres));
        }
        [TestCase]
        public void MultiplicationTestCase1()
        {
            double ares = p.Multiplication(5, 4);
            double eres = 20;
            Assert.That(ares, Is.EqualTo(eres));
        }
        [TestCase]
        public void MultiplicationTestCase2()
        {
            double ares = p.Multiplication(4, 4);
            double eres = 16;
            Assert.That(ares, Is.EqualTo(eres));
        }
        [TestCase]
        public void DivisionTestcase1()
        {
            double ares = p.Division(10, 10);
            Assert.That(1, Is.EqualTo(ares));
        }
        [TestCase]
        public void DivisionTestcase2()
        {
            try
            {
                double f = p.Division(10, 0);
                // Assert.Fail("xyz",);

            }
            catch (Exception v)
            {
                Assert.AreEqual("Second Parameter Can't be Zero", v.Message);

            }
        }
        [TearDown]

        public void CleanUp()

        {
            p.AllClear();
            result = p.GetResult;
            Console.WriteLine(result);
            Assert.AreEqual(0, result);

        }


    }
}
