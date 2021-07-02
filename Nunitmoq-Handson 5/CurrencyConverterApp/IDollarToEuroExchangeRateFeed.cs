using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverterApp
{
    public interface IDollarToEuroExchangeRateFeed
    {
        double GetActualUSDollarValue();
    }
}
