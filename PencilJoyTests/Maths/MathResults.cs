using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PencilJoyTests
{
    class MathResults
    {
        #region Preview
        internal static string checkSymbolCurrency;
        internal static string checkValueCurrency;
        #endregion

        #region Results in the bag
        static internal bool verifyCurencyInGrandPriceInBag;
        static internal bool verifyCurencyInSubtotalPriceInBag;
        static internal bool comparePriceBookInBag;
        //static internal bool verifyPriceFirstBook;
        //internal static bool checkSubtotalPrice;
        //internal static bool checkGrandPrice;
        //internal static bool verifyCurrencyFirstBook;
        #endregion

        #region Checkout
        static internal string verifyPriceBookInCheckout;
        static internal string verifyCurrencyInCheckout;
        static internal string verifyDiscountCodeInCheckout;
        static internal string verifyTotalPriceInCheckout;
        #endregion

        #region Methods
        //public bool CompareListBook(List<double> actualPriceBook, List<double> expectedPriceBook)
        //{
        //    return expectedPriceBook.SequenceEqual(actualPriceBook);
        //}
        // public bool ComparePrices(double actualPrice, double expectedPrice)
        //{
        //    return (expectedPrice.Equals(actualPrice));
        //}
        #endregion

    }
}
