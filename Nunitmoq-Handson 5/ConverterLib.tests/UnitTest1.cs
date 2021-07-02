using NUnit.Framework;
using System;
using Moq;
using CurrencyConverterApp;

namespace ConverterLib.tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Currency_Conversion_Check()
        {
            double usd = 9.5;
            double con = 100;
            Mock<IDollarToEuroExchangeRateFeed> usdtoeu = new Mock<IDollarToEuroExchangeRateFeed>();
            usdtoeu.Setup(t => t.GetActualUSDollarValue()).Returns(usd);
            Converter c = new Converter(usdtoeu.Object);
            var eu = c.USDToEuro(con);
            Assert.AreEqual(eu, 950);
        }

    }
}
