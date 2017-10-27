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
    class CheckoutBillingAddressPage
    {
        private WebDriverWait _waitDriver;
        private CheckoutAddressData checkoutBillingAddressData;

        public CheckoutBillingAddressPage(WebDriverWait waitDriver)
        {
            _waitDriver = waitDriver;
        }
        public CheckoutBillingAddressPage(WebDriverWait waitDriver, CheckoutAddressData checkoutBillingAddressData)
        {
            _waitDriver = waitDriver;
            this.checkoutBillingAddressData = checkoutBillingAddressData;
        }
        #region Objects Shipping Address
        private IWebElement FirstNameTextBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("ba-firstname")));
            }
        }
        private IWebElement LastNameTextBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("ba-lastname")));
            }
        }
        private IWebElement StreetAddressTextBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("ba-address")));
            }
        }
        private IWebElement CityTextBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("ba-city")));
            }
        }
        private IWebElement StateRegionDropdown
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("ba-spg-us")));
            }
        }
     
        private IWebElement ZipCodeTextBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("ba-code")));
            }
        }
        private IWebElement CountryDropdown
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("ba-country")));
            }
        }
      
        private IWebElement PhoneTextBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("ba-tel")));
            }
        }
        private IWebElement BillToTheAddressCheckBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("the-bame-ship")));
            }
        }
        #endregion
        
        #region Methods

        public void ClearInputs()
        {
            FirstNameTextBox.Clear();
            LastNameTextBox.Clear();
            StreetAddressTextBox.Clear();
            CityTextBox.Clear();
            ZipCodeTextBox.Clear();
            PhoneTextBox.Clear();
        }
        public string LoginIntoBillingAddress()
        {
            SelectElement selectCountry = new SelectElement(CountryDropdown);
            ClearInputs();
            FirstNameTextBox.SendKeys(checkoutBillingAddressData.Username);
            LastNameTextBox.SendKeys(checkoutBillingAddressData.Lastname);
            StreetAddressTextBox.SendKeys(checkoutBillingAddressData.Street);
            ZipCodeTextBox.SendKeys(checkoutBillingAddressData.ZipCode);
            CountryDropdown.SendKeys(Keys.Enter);
            selectCountry.SelectByIndex(checkoutBillingAddressData.NumberCountry);
            CityTextBox.SendKeys(checkoutBillingAddressData.City);
            PhoneTextBox.SendKeys(checkoutBillingAddressData.Phone);
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }
      
        public string ShipToThisAddress()
        {
            BillToTheAddressCheckBox.SendKeys(Keys.Enter);
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }
        #endregion
       
    }
}
