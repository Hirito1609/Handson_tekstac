using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyConverterApp;

namespace ConverterLib
{
    public class Converter : IConverter
    {
        IDollarToEuroExchangeRateFeed _exchangeRateFeed;
        public Converter(IDollarToEuroExchangeRateFeed exchangeRateFeed)
        {
            _exchangeRateFeed = exchangeRateFeed;
        }

        public double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        public double KilogramToPound(double kilogram)
        {
            return kilogram * 2.205;
        }

        public double KilometerToMile(double kilometer)
        {
            return kilometer / 1.609;
        }

        public double LiterToGallon(double liter)
        {
            return liter / 3.785;
        }

        public double USDToEuro(double dollar)
        {
            return dollar * _exchangeRateFeed.GetActualUSDollarValue();
        }
    }
}
