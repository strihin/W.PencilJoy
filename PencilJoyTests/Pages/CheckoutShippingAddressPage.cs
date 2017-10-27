using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PencilJoyTests.Data;


namespace PencilJoyTests.Pages
{
    class CheckoutShippingAddressPage
    {  
        private WebDriverWait _waitDriver;
        private CheckoutAddressData checkoutShippingAddressData;
       
        public CheckoutShippingAddressPage(WebDriverWait waitDriver)
        {
            _waitDriver = waitDriver;
        }
        public CheckoutShippingAddressPage(WebDriverWait waitDriver, CheckoutAddressData checkoutAddressData)
        {
            _waitDriver = waitDriver;
            this.checkoutShippingAddressData = checkoutAddressData;
        }
        #region Objects Shipping Address
        private IWebElement  FirstNameTextBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("sa-firstname")));
            }
        }
        private IWebElement LastNameTextBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("sa-lastname")));
            }
        }
        private IWebElement StreetAddressTextBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("sa-address")));
            }
        }
        private IWebElement CityTextBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("sa-city")));
              
            }
        }
        private IWebElement StateRegionDropdown
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("sa-spg-us")));
            }
        }
        private IWebElement ZipCodeTextBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("sa-code")));
            }
        }
        private IWebElement CountryDropdown
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("sa-country")));
            }
        }
        private IWebElement PhoneTextBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("sa-tel")));
            }
        }
        private IWebElement BillToTheAddressCheckBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.CssSelector("#newcustomer > div:nth-child(1) > div.form-block > label")));
            }
        }
        #endregion

        #region Methods
        public string LoginIntoShippingAddress()
        {
            SelectElement selectCountry = new SelectElement(CountryDropdown);

            FirstNameTextBox.SendKeys(checkoutShippingAddressData.Username);
            LastNameTextBox.SendKeys(checkoutShippingAddressData.Lastname);
            StreetAddressTextBox.SendKeys(checkoutShippingAddressData.Street);
            ZipCodeTextBox.SendKeys(checkoutShippingAddressData.ZipCode);
            CountryDropdown.SendKeys(Keys.Enter);
            selectCountry.SelectByIndex(checkoutShippingAddressData.NumberCountry);
            CityTextBox.SendKeys(checkoutShippingAddressData.City);
            PhoneTextBox.SendKeys(checkoutShippingAddressData.Phone);
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }
        public string BillToThisAddress()
        {
            BillToTheAddressCheckBox.SendKeys(Keys.Enter);
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }
        #endregion
    }
}
