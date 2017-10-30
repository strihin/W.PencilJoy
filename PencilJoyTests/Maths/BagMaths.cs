using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PencilJoyTests.Data;

namespace PencilJoyTests.Maths
{
    class BagMath:Converter
    {
        #region Objects
        internal Order ExpectedOrder { get; set; }
        internal Order ActualOrder { get;set; }
        #endregion
        
        #region ctor
        public BagMath()
        {
            this.ActualOrder = new Order();
            this.ExpectedOrder = new Order();
        }
        #endregion

       #region Methods

        public void FullCheckingData()
        {
            
        }
        public double VerifyPriceInTheFirstBook()
        {
            MathResults.verifyPriceFirstBook = (ExpectedOrder.PriceBook[0] ==
                        FullAdminData.CurrencyList[IndexCurrency].currencyValue)
                ? true : false;
            return MathResults.verifyPriceFirstBook ? FullAdminData.CurrencyList[IndexCurrency].currencyValue : 0;
        }

        public void CalculateTotalPriceInBag()
        {
            //  VerifyPriceInTheFirstBook();

            foreach (var priceBook in ExpectedOrder.PriceBook)
            {
                ActualOrder.SubtotalPrice += priceBook;
            }
            if (ExpectedOrder.DiscountCode != -1)
            {
                ActualOrder.SubtotalPrice -= System.Math.Round(ExpectedOrder.DiscountCode / 100 * ActualOrder.SubtotalPrice, 2);
            }
            ActualOrder.GrandPrice = ActualOrder.SubtotalPrice;

            MathResults.checkSubtotalPrice = MathResults.ComparePrices(System.Math.Round(ActualOrder.SubtotalPrice, 2), System.Math.Round(ExpectedOrder.SubtotalPrice, 2));
            MathResults.checkGrandPrice = MathResults.ComparePrices(System.Math.Round(ActualOrder.GrandPrice, 2), System.Math.Round(ExpectedOrder.GrandPrice, 2));
        }
        
          public void VerifyActionForListBook()
          {
              double discountPercent = 0.1;
              ActualOrder.PriceBook = new List<double>(ExpectedOrder.PriceBook.Count);
              ActualOrder.PriceBook.Add(ExpectedOrder.PriceBook[0]);
              if (ExpectedOrder.PriceBook.Count > 1)
              {
                  for (int i = 1; i < ExpectedOrder.PriceBook.Count; i++)
                  {
                      //calculate price for next book with discount
                      ActualOrder.PriceBook.Add(System.Math.Round(ActualOrder.PriceBook[0] - ActualOrder.PriceBook[0] * discountPercent, 2));
                      if (discountPercent != 0.25)
                          discountPercent += 0.05;
                  }
              }
              MathResults.CompareListBook(ActualOrder.PriceBook, ExpectedOrder.PriceBook);
            //  MathResults.comparePriceBookInBag = ExpectedOrder.PriceBook.SequenceEqual(ActualOrder.PriceBook);
          }
        #endregion
    }
}
