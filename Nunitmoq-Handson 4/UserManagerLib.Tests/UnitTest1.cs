using System;
using NUnit.Framework;

namespace UserManagerLib.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        User user;
        [SetUp]
        public void Setup()
        {
            user = new User();
        }

        [Test]
        [TestCase("abcdef0001")]
        [TestCase("xyz")]
        [TestCase("")]
        [TestCase("ABCD0032AD")]
        public void Createuser_Scenario_ExpectedOutcome(string temp)
        {
            try
            {
                user.CreateUser(new User { PANCardNo = temp });
            }
            catch (NullReferenceException e)
            {
                Assert.That(e.Message, Is.EqualTo("Invalid Pan Card Number"));
            }
            catch (FormatException e)
            {
                Assert.That(e.Message, Is.EqualTo("Pan Card Number Should contain only 10 characters"));
            }
        }
    }
}
