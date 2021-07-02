using System;
using NUnit.Framework;

namespace SeasonsLib.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        SeasonTeller season;
        [SetUp]
        public void Setup()
        {
            season = new SeasonTeller();

    }
    [TearDown]
    public void Teardown()
    {
        season = null;
    }
    [Test]
    [TestCase("March", "Spring")]
    [TestCase("may", "Summer")]
    [TestCase("August", "Monsoon")]
    [TestCase("january", "Winter")]
    [TestCase("blah", "Invalid Season")]
    public void DisplaySeason_Printseasons_correctseason(string a, string expected)
    {
        string result = season.DisplaySeasonBy(a);
        Assert.That(expected, Is.EqualTo(result));
    }

}
}
