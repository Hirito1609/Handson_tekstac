using System;
using NUnit.Framework;
using LeapYearCalculatorLib;

namespace LeapYearCalculatorLib.Tests
{
    [TestFixture]
    public class leapyeartests
    {
        [Test]
        [TestCase(1740,-1)]
        [TestCase(2004, 1)]
        [TestCase(2005, 0)]
        [TestCase(10000, -1)]
        public void Isleapyear_checkvalidity(int year, int expectedresult)
        {
            LeapYearCalculator leapYearCalculator = new LeapYearCalculator();
            int result = leapYearCalculator.IsLeapYear(year);
            Assert.That(result, Is.EqualTo(expectedresult));

        }
    }
}
