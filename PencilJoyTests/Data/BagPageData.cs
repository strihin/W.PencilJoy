using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PencilJoyTests.Data
{
    class BagPageData
    {
        #region Objects
        internal string DiscountCode { get; set; }
        internal string Currency { get; set; }
        #endregion
        #region Ctors

        public BagPageData(string DiscountCode, string Currency)
        {
            DiscountCode = DiscountCode;
            Currency = Currency;
        }
        #endregion
        #region Methods

        public void GetRandomDiscountCode()
        {
            GetRandomDiscountCode();
        }
        #endregion
    }
}
