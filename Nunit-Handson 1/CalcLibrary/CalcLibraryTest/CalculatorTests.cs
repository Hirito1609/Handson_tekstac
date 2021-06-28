using System;
using NUnit.Framework;
using CalcLibrary;

namespace CalcLibraryTest
{
    [TestFixture]
    public class CalculatorTests
    {
        SimpleCalculator SimpleCalculator;
        double Result;
        [SetUp]
        public void SetUp()
        {
            SimpleCalculator = new SimpleCalculator();
            Result = 0;
        }
        [TearDown]
        public void TearDown()
        {
            SimpleCalculator = null;
        }
        [Test]
        public void Addition_result()
        {
            double expectedResult = 4;

            Result = SimpleCalculator.Addition(2, 2);

            Assert.AreEqual(expectedResult, Result);
        }
        [Test]
        public void Subtraction_result()
        {

            double expectedResult = 5;

            Result = SimpleCalculator.Subtraction(10, 5);

            Assert.AreEqual(expectedResult, Result);
        }

        [Test]
        public void Multiplication_result()
        {
            double expectedResult = 16;

            Result = SimpleCalculator.Multiplication(8, 2);

            Assert.AreEqual(expectedResult, Result);
        }

        [Test]
        public void Division_result()
        {
            double expectedResult = 10;

            double Result = SimpleCalculator.Division(20, 2);

            Assert.AreEqual(expectedResult, Result);
        }

    }
}
