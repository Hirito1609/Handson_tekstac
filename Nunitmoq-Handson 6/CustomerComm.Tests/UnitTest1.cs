using NUnit.Framework;
using System;
using Moq;
using CustomerCommLib;

namespace CustomerComm.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        
        [OneTimeSetUp]
        public void Init()
        {
            
        }
        [Test]
        [TestCase("abc@efg.com","check")]
        public void TestMethod1(string a, string b)
        {
            Mock<IMailSender> mclient = new Mock<IMailSender>();
        }
    }
}
