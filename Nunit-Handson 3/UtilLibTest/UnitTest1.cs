using System;
using NUnit.Framework;
using UtilLib;

namespace UtilLibTest
{
    [TestFixture]
    public class UnitTest1
    {
        UrlHostNameParser u;

        [SetUp]
        public void SetUp()
        {
            u = new UrlHostNameParser();
        }
        [TearDown]
        public void Dispose()
        {
            u = null;
        }

        [TestCase]
        public void Testcase1()
        {
            string act = u.ParseHostName("https://Facebook.com");
            string exp = "Facebook.com";
            Assert.That(act, Is.EqualTo(exp));
        }
        [TestCase]
        public void Testcase2()
        {

            string act = u.ParseHostName("http://twitter.com");
            string exp = "twitter.com";
            Assert.That(act, Is.EqualTo(exp));
        }
        [TestCase]
        public void Testcase3()
        {
            var ex = Assert.Throws<FormatException>(() => u.ParseHostName("https12://gmail.com"));
            Assert.That(ex.Message, Is.EqualTo("Url is not in correct format"));
        }

    }
}
