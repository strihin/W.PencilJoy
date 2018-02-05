using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PencilJoyTests.Maths
{
    public class Price
    {
        private double Value { get; set; }
        private string Currency { get; set; }

        public Price(double Value, string Currency)
        {
            Value = Value;
            Currency = Currency;
        }

        public bool ComparePrices(Price firstPage, Price secondPage)
        {
            return ((firstPage.Value == secondPage.Value) && (secondPage.Currency == secondPage.Currency));
        }

        public static bool CompareCurrencies(string currencyExpected, string currencyActual)
        {
      //      bool result = false;
            return (currencyExpected == currencyActual);
        }
    }
}
