using System.Collections.Generic;
using PencilJoyTests.Data;

namespace PencilJoyTests.Maths
{
    class CheckoutMaths: Converter
    {
        #region Objects
         internal Order ExpectedOrder { get; set; }
         internal Order ActualOrder { get; set; }
         
         internal List<string> CheckoutPriceBook { get; set; }
         internal string CheckoutDiscountCode { get; set; }
         internal string CheckoutGrandPrice { get; set; }
         internal string CheckoutCurrency { get; set; }
         private BagMaths bagMathData { get; set; }

        #endregion
        #region Ctors
        public CheckoutMaths() { }

        public CheckoutMaths(BagMaths bagMathData)
        {
            this.bagMathData = bagMathData;
    
            this.ActualOrder = new Order();
            this.ExpectedOrder = new Order();
        
        }
        #endregion
        public double VerifyPriceInTheFirstBook()
        {
            MathResults.verifyPriceFirstBook = (ExpectedOrder.PriceBook[0] ==
                        FullAdminData.CurrencyList[IndexCurrency].currencyValue)
                ? true : false;
            return MathResults.verifyPriceFirstBook ? FullAdminData.CurrencyList[IndexCurrency].currencyValue : 0;
        }
  
        #region Methods
        public void VerifyPriceBook()
        {
            MathResults.verifyPriceBookInCheckout = bagMathData.ActualOrder.PriceBook.SequenceEqual(ExpectedOrder.PriceBook)
                ? "OK" : "Not OK";
        }
      
        public void VerifyDiscountCode()
        {
            MathResults.verifyDiscountCodeInCheckout = (ExpectedOrder.DiscountCode== bagMathData.ActualOrder.DiscountCode)
                 ? "OK" : "Not OK";
        }
      
        public void VerifyCurrency()
        {
            MathResults.verifyDiscountCodeInCheckout = (ExpectedOrder.CurrencySymbol== bagMathData.ActualOrder.CurrencySymbol)
                ? "OK" : "Not OK";
        }
        public void VerifyGrandPrice()
        {
            MathResults.verifyCurencyInGrandPriceInBag = (ExpectedOrder.GrandPrice == System.Math.Round(bagMathData.ActualOrder.GrandPrice,2))
                ? true : false;
        }
       #endregion
      


    }
}
