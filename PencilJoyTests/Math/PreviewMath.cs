using PencilJoyTests.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PencilJoyTests.Math
{
    class PreviewMath : Converter
    {
        #region Objects
        internal string PreviewPriceBook { get; set; }
        #endregion

        #region Methods
        public void PreviewConvert()
        {
            RemoveOldPrice(PreviewPriceBook);
            RemoveCurrencyFromPrice(PreviewPriceBook);
        }
        public void VerifyCurrencyInButton(string currencyInButton)
        {
            string currencySymbolInSelector = FullAdminData.CurrencyList[IndexCurrency].currencySymbol;
            string currencyValueInSelector = FullAdminData.CurrencyList[IndexCurrency].currencyValue.ToString();

            MathResults.checkSymbolCurrency = (currencyInButton.Contains(currencySymbolInSelector))
                ? "The currency is true for selector"
                : "Not OK";
            MathResults.checkValueCurrency = (currencyInButton.Replace('.', ',').Contains(currencyValueInSelector))
                ? ("The value of " + currencySymbolInSelector + " is true in the button")
                : "Not OK";
        }
       
        #endregion
    }
}
