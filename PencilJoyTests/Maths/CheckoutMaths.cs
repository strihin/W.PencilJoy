using System.Collections.Generic;
using System.Linq;
using PencilJoyTests.Data;

namespace PencilJoyTests.Maths
{
    class CheckoutMaths: Converter
    {
        #region Objects
        /*
         internal Order ExpectedOrder { get; set; }
         internal Order ActualOrder { get; set; }
         */
         internal List<string> CheckoutPriceBook { get; set; }
         internal string CheckoutDiscountCode { get; set; }
         internal string CheckoutGrandPrice { get; set; }
         internal string CheckoutCurrency { get; set; }
         private BagMaths bagMathData { get; set; }

         internal MathResults mathResults = new MathResults();

        #endregion
        #region Ctors
        public CheckoutMaths() { }

        public CheckoutMaths(BagMaths bagMathData)
        {
            this.bagMathData = bagMathData;
    /*
            this.ActualOrder = new Order();
            this.ExpectedOrder = new Order();
     */
        }
        #endregion
        public double VerifyPriceInTheFirstBook()
        {
            MathResults.verifyPriceFirstBook = (Helper.ExpectedOrder.PriceBook[0] ==
                        FullAdminData.CurrencyList[IndexCurrency].currencyValue)
                ? true : false;
            return MathResults.verifyPriceFirstBook ? FullAdminData.CurrencyList[IndexCurrency].currencyValue : 0;
        }
  
        #region Methods
        public void VerifyPriceBook()
        {
            MathResults.verifyPriceBookInCheckout = Helper.ActualOrder.PriceBook.SequenceEqual(Helper.ExpectedOrder.PriceBook)
                ? "OK" : "Not OK";
        }
      
        public void VerifyDiscountCode()
        {
            MathResults.verifyDiscountCodeInCheckout = (Helper.ExpectedOrder.DiscountCode == Helper.ActualOrder.DiscountCode)
                 ? "OK" : "Not OK";
        }
      
        public void VerifyCurrency()
        {
            MathResults.verifyDiscountCodeInCheckout = (Helper.ExpectedOrder.CurrencySymbol == Helper.ActualOrder.CurrencySymbol)
                ? "OK" : "Not OK";
        }
        public void VerifyGrandPrice()
        {
            MathResults.verifyCurencyInGrandPriceInBag = (Helper.ExpectedOrder.GrandPrice == System.Math.Round(Helper.ActualOrder.GrandPrice, 2))
                ? true : false;
        }
        public bool ComparePriceBookLists()
        {
            return Helper.CompareListBook(Helper.ActualOrder.PriceBook, Helper.ExpectedOrder.PriceBook);
        }

        public bool CompareUnitPrice()
        {
            return Helper.ComparePrices(Helper.ActualOrder.GrandPrice, Helper.ExpectedOrder.GrandPrice);
        }

       #endregion
    }
}
