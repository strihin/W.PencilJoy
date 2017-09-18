using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Collections.Generic;

namespace PencilJoy
{
    class CheckOutPage
    {
        IWebDriver webDriver;
        public CheckOutPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        #region Objects Shipping Address
        private IWebElement  FirstNameTextBox
        {
            get
            {
                return webDriver.FindElement(By.Id("sa-firstname"));
            }
        }
        private IWebElement LastNameTextBox
        {
            get
            {
                return webDriver.FindElement(By.Id("sa-lastname"));
            }
        }
        private IWebElement StreetAddressTextBox
        {
            get
            {
                return webDriver.FindElement(By.Id("sa-address"));
            }
        }
        private IWebElement CityTextBox
        {
            get
            {
                return webDriver.FindElement(By.Id("sa-city"));
            }
        }
        private IWebElement StateRegionDropdown
        {
            get
            {
                return webDriver.FindElement(By.Id("sa-spg-us"));
            }
        }
        private IWebElement StateRegionDropItem
        {
            get
            {
                return webDriver.FindElement(By.CssSelector("#sa-spg-us > option:nth-child(4)"));
            }
        }
        private IWebElement ZipCodeTextBox
        {
            get
            {
                return webDriver.FindElement(By.Id("sa-code"));
            }
        }
        private IWebElement CountryDropdown
        {
            get
            {
                return webDriver.FindElement(By.Id("sa-country"));
            }
        }
        private IWebElement CountryDropItem
        {
            get
            {
                return webDriver.FindElement(By.CssSelector("#sa-country > option:nth-child(1)"));
            }
        }
        private IWebElement PhoneTextBox
        {
            get
            {
                return webDriver.FindElement(By.Id("sa-tel"));
            }
        }
        #endregion

        #region Objects BillToTheAddress
        private IWebElement BillToTheAddressCheckBox
        {
            get
            {
                return webDriver.FindElement(By.Id("the-same-bill"));
            }
        }
        #endregion

        #region Objects Payment
      
        private IWebElement CreditCardInput1
        { 
            get
            {
                return webDriver.FindElement(By.CssSelector("#credit-card > div > div.credit-input > input:nth-child(1)"));              
            }
        }
        private IWebElement CreditCardInput2
        {
            get
            {
                return webDriver.FindElement(By.CssSelector("#credit-card > div > div.credit-input > input:nth-child(2)"));
            }
        }
        private IWebElement CreditCardInput3
        {
            get
            {
                return webDriver.FindElement(By.CssSelector("#credit-card > div > div.credit-input > input:nth-child(3)"));
            }
        }
        private IWebElement CreditCardInput4
        {
            get
            {
                return webDriver.FindElement(By.CssSelector("#credit-card > div > div.credit-input > input:nth-child(4)"));
            }
        }
        private IWebElement ExpirationMonthDropdown
        {
            get
            {
                return webDriver.FindElement(By.Id("select-month"));
            }
        }
        private IWebElement ExpirationMonthDropitem
        {
            get
            {
                return webDriver.FindElement(By.CssSelector("#select-month > option:nth-child(6)"));
            }
        }
        private IWebElement ExpirationYearDropdown
        {
            get
            {
                return webDriver.FindElement(By.Id("select-year"));
            }
        }
        private IWebElement ExpirationYearDropitem
        {
            get
            {
                return webDriver.FindElement(By.Id("#select-year > option:nth-child(1)"));
            }
        }
        private IWebElement CardVerifacationValueTextBox
        {
            get
            {
                return webDriver.FindElement(By.Id("cvn"));
            }
        }
        private IWebElement PlaceYourOrderButton
        {
            get
            {
                return webDriver.FindElement(By.Name("cardSubmit"));
            }
        }
        #endregion

        #region Methods
       
        public void LoginIntoShippingAddress(string username, string lastname, string street, string city, string zipCode, string phone)
        {
            FirstNameTextBox.SendKeys(username);
            LastNameTextBox.SendKeys(lastname);
            StreetAddressTextBox.SendKeys(street);
            CityTextBox.SendKeys(city);
            ZipCodeTextBox.SendKeys(zipCode);
            PhoneTextBox.SendKeys(phone);   
        }
     
        public void BillToThisAddress()
        {
           BillToTheAddressCheckBox.Click();
        }
        public string PaymentAddress(string creditCardInput, string CardVerifacationValue)
        {
            IWebElement[] FullCreditCard = { CreditCardInput1, CreditCardInput2, CreditCardInput3, CreditCardInput4 };     
           
            for(int i=0; i< FullCreditCard.Length; i++)
                FullCreditCard[i].SendKeys(creditCardInput);

            ExpirationMonthDropdown.Click();
            ExpirationMonthDropitem.Click();

         //   ExpirationYearDropdown.Click();
         //   ExpirationYearDropitem.Click();

            CardVerifacationValueTextBox.SendKeys(CardVerifacationValue);

            string CheckoutPageItem = webDriver.Title;
            PlaceYourOrderButton.Click();     
            return CheckoutPageItem;
        }

        #endregion
    }
}
