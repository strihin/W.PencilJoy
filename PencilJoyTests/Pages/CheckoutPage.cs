using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PencilJoyTests.Data;

namespace PencilJoyTests.Pages
{
    class CheckOutPage
    {
      
        private WebDriverWait _waitDriver;
        private CheckoutPaymentData checkoutPaymentData;
        public CheckOutPage(WebDriverWait waitDriver)
        {
            _waitDriver = waitDriver;
        }
        public CheckOutPage(WebDriverWait waitDriver, CheckoutPaymentData checkoutPaymentData)
        {
            _waitDriver = waitDriver;
            this.checkoutPaymentData = checkoutPaymentData;
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
        private IWebElement StateRegionDropItem
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.CssSelector("#sa-spg-us > option:nth-child(4)")));
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
        private IWebElement CountryDropItem
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.CssSelector("#sa-country > option:nth-child(1)")));
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
        #endregion

        #region Objects BillToTheAddress
        private IWebElement BillToTheAddressCheckBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("the-same-bill")));
            }
        }
        #endregion

        #region Objects Payment
      
        private IWebElement CreditCardInput1
        { 
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.CssSelector("#credit-card > div > div.credit-input > input:nth-child(1)")));
            }
        }
        private IWebElement CreditCardInput2
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.CssSelector("#credit-card > div > div.credit-input > input:nth-child(2)")));
            }
        }
        private IWebElement CreditCardInput3
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.CssSelector("#credit-card > div > div.credit-input > input:nth-child(3)")));
            }
        }
        private IWebElement CreditCardInput4
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.CssSelector("#credit-card > div > div.credit-input > input:nth-child(4)")));
            }
        }
        private IWebElement ExpirationMonthDropdown
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("select-month")));
            }
        }
        private IWebElement ExpirationMonthDropitem
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.CssSelector("#select-month > option:nth-child(" + checkoutPaymentData.SelectMonth + ")")));
            }
        }
        private IWebElement ExpirationYearDropdown
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("select-year")));
            }
        }
        private IWebElement ExpirationYearDropitem
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.CssSelector("#select-year > option:nth-child(" + checkoutPaymentData.SelectYear + ")")));
            }
        }
        private IWebElement CardVerifacationValueTextBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("cvn")));
            }
        }
        private IWebElement PlaceYourOrderButton
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Name("cardSubmit")));
            }
        }

        private IWebElement PaypalTab
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                     By.CssSelector("#payment-method > ul > li:nth-child(2) > a")));
            }
        }

        private IWebElement PaypalButton
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.ClassName("pay-bth")));
            }
        }
        #endregion

        #region Methods

        public string LoginIntoShippingAddress(CheckoutAddressData checkoutAddressData)
        {
            FirstNameTextBox.SendKeys(checkoutAddressData.Username);
            LastNameTextBox.SendKeys(checkoutAddressData.Lastname);
            StreetAddressTextBox.SendKeys(checkoutAddressData.Street);
            CityTextBox.SendKeys(checkoutAddressData.City);
            ZipCodeTextBox.SendKeys(checkoutAddressData.ZipCode);
            PhoneTextBox.SendKeys(checkoutAddressData.Phone);
            return System.Reflection.MethodBase.GetCurrentMethod().Name ;
        }
     
        public string BillToThisAddress()
        {
           BillToTheAddressCheckBox.SendKeys(Keys.Enter);
           return System.Reflection.MethodBase.GetCurrentMethod().Name ;
        }

        public string PaymentMethodPaypal()
        {
            PaypalTab.SendKeys(Keys.Enter);
            PaypalButton.SendKeys(Keys.Enter);
            return System.Reflection.MethodBase.GetCurrentMethod().Name ;
        }
  
        public string PaymentAddress()
        {
            IWebElement[] fullCreditCard = { CreditCardInput1, CreditCardInput2, CreditCardInput3, CreditCardInput4 };

            for (int i = 0; i < fullCreditCard.Length; i++)
            {
                fullCreditCard[i].SendKeys(checkoutPaymentData.CreditCardInput);
            }
            ExpirationMonthDropdown.Click();
            ExpirationMonthDropitem.Click();

            ExpirationYearDropdown.Click();
            ExpirationYearDropitem.Click();

            CardVerifacationValueTextBox.SendKeys(checkoutPaymentData.CardVerifacationValue);

            PlaceYourOrderButton.SendKeys(Keys.Enter);

            return System.Reflection.MethodBase.GetCurrentMethod().Name ;
        }
        #endregion
    }
}
