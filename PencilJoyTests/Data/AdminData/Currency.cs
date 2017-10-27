using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PencilJoyTests.Data.AdminData
{
    class Currency
    {
        internal string currencyName { get; set; }
        internal string currencySymbol { get; set; }
        internal double currencyValue { get; set; }

        public Currency(string currencyName, string currencySymbol, double currencyValue)
        {
            this.currencyName = currencyName;
            this.currencyValue = currencyValue;
            this.currencySymbol = currencySymbol;
        }
    }
}
