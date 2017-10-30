using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PencilJoyTests.Maths
{
    class Order
    {
        internal List<double> PriceBook { get; set; }
        internal double DiscountCode { get; set; }
        internal double SubtotalPrice { get; set; }
        internal double GrandPrice { get; set; }
        internal string CurrencySymbol { get; set; }

        public Order()
        {
            PriceBook = new List<double>();
        }
    }
}
