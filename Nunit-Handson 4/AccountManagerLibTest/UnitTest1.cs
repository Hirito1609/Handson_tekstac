using NUnit.Framework;
using System;
using AccountsManagerLib;

namespace AccountManagerLibTest
{
    [TestFixture]
    public class UnitTest1
    {
        AccountsManager u;

        [SetUp]
        public void SetUp()
        {
            u = new AccountsManager();
        }
        [TearDown]
        public void Dispose()
        {
            u = null;
        }

        [TestCase]
        public void LoginTestcase1()
        {
            string exp = "Invalid user id/password";
            string act = u.ValidateUser("user_22", "secret@user12s");
            Assert.That(act, Is.EqualTo(exp));
        }
        [TestCase]
        public void LoginTestcase2()
        {
            try
            {
                String f = u.ValidateUser("user2", "");
                // Assert.Fail("xyz",);

            }
            catch (Exception v)
            {
                Assert.AreEqual("Both user id and password are mandatory", v.Message);

            }
        }
        [TestCase]
        public void LoginTestcase3()
        {

            string act = u.ValidateUser("user_11", "secret@user11");
            string exp = string.Format("Welcome user_11!!!");
            Assert.That(act, Is.EqualTo(exp));
        }
        [TestCase]
        public void LoginTestcase4()
        {
            string exp = "Invalid user id/password";
            string act = u.ValidateUser("user_23", "secret@user12s");
            Assert.That(act, Is.EqualTo(exp));
        }

    }
}
