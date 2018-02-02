using System;
using System.Collections.Generic;
using PencilJoyTests.Data;

namespace PencilJoyTests.Maths
{
    class BagMaths : Converter
    {
        #region Objects
        
        /*
        internal Order ExpectedOrder { get; set; }
        internal Order ActualOrder { get; set; }
        #endregion

        #region ctor
        public BagMaths()
        {
            this.ActualOrder = new Order();
            this.ExpectedOrder = new Order();
        }
         */
        #endregion
        
        #region Methods

        public void FullCheckingData()
        {

        }
        public bool ComparePriceInTheFirstBook(double expectedPrice)
        {
            Helper.verifyPriceFirstBook = (Helper.ExpectedOrder.PriceBook[0] ==
                                                FullAdminData.CurrencyList[IndexCurrency].currencyValue);
          
            return (expectedPrice == Helper.ExpectedOrder.PriceBook[0]);
        }

        public double GetFirstBookPrice()
        {
            return Helper.ExpectedOrder.PriceBook[0];
        }
        public string VerifyCurrencyInTheFirstBook()
        {
            var test = (Helper.ExpectedOrder.CurrencySymbol ==
                                                FullAdminData.CurrencyList[IndexCurrency].currencySymbol);
            return Helper.verifyCurrencyFirstBook ? FullAdminData.CurrencyList[IndexCurrency].currencySymbol : null;
        }
        public void CalculateTotalPriceInBag()
        {
            //  VerifyPriceInTheFirstBook();

            foreach (var priceBook in Helper.ExpectedOrder.PriceBook)
            {
                Helper.ActualOrder.SubtotalPrice += priceBook;
            }
            if (Helper.ExpectedOrder.DiscountCode != -1)
            {
                Helper.ActualOrder.SubtotalPrice -= Math.Round(Helper.ExpectedOrder.DiscountCode / 100 * Helper.ActualOrder.SubtotalPrice, 2);
            }
            Helper.ActualOrder.GrandPrice = Helper.ActualOrder.SubtotalPrice;

            Helper.checkSubtotalPrice = Helper.ComparePrices(Math.Round(Helper.ActualOrder.SubtotalPrice, 2), Math.Round(Helper.ExpectedOrder.SubtotalPrice, 2));
            Helper.checkGrandPrice = Helper.ComparePrices(Math.Round(Helper.ActualOrder.GrandPrice, 2), Math.Round(Helper.ExpectedOrder.GrandPrice, 2));
        }

        public void VerifyActionForListBook()
        {
            double discountPercent = 0.1;
            Helper.ActualOrder.PriceBook = new List<double>(Helper.ExpectedOrder.PriceBook.Count);
            Helper.ActualOrder.PriceBook.Add(Helper.ExpectedOrder.PriceBook[0]);

            if (Helper.ExpectedOrder.PriceBook.Count > 1)
            {
                for (int i = 1; i < Helper.ExpectedOrder.PriceBook.Count; i++)
                {
                    //calculate price for next book with discount
                    Helper.ActualOrder.PriceBook.Add(Math.Round(Helper.ActualOrder.PriceBook[0] - Helper.ActualOrder.PriceBook[0] * discountPercent, 2));
                    if (discountPercent != 0.25)
                        discountPercent += 0.05;
                }
            }
            //  MathResults.comparePriceBookInBag = ExpectedOrder.PriceBook.SequenceEqual(ActualOrder.PriceBook);
        }

        
        #endregion
    }
}
