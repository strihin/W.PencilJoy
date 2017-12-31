using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PencilJoyTests.Data;

namespace PencilJoyTests.Pages
{
    class FooterPage
    {
        private readonly WebDriverWait _waitDriver;

        #region Elements
        private IWebElement CurrencySelect
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Id("g-currency-switch")));
            }
        }
        #endregion

        #region Methods
        public void EditCurrency(string currencyName)
        {
            SelectElement currencyItem = new SelectElement(CurrencySelect);
            currencyItem.SelectByText(currencyName);
        }
        public bool IsActiveCurrency(string fieldName, string expectedCurrency)
        {
            SelectElement currencyItem = new SelectElement(CurrencySelect);
            var actualCurrency = currencyItem.SelectedOption.Text;
            return Helper.CompareCurrencies(expectedCurrency, actualCurrency);
        }

        public bool IsCorrectCurrency(string fieldName, string expectedCurrency)
        {
            var symbolList = FullAdminData.GetCurrencySymbolList();
            var PriceField = Helper.SearchInputDoubleBlock(Helper.SearchFieldByName(_waitDriver, fieldName),expectedCurrency);
            foreach (var currency in symbolList)
            {
                currency.
            }
        }

        #endregion
    }

}
