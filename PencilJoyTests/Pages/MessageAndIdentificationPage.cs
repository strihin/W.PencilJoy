using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PencilJoyTests.BddCore;
using PencilJoyTests.Data;
using PencilJoyTests.Maths;

namespace PencilJoyTests.Pages
{
    class MessageAndIdentificationPage
    {
        
        private MessageAndIdentificationData _messageAndIdentificationData;

        public MessageAndIdentificationPage() { }
        public MessageAndIdentificationPage(MessageAndIdentificationData messageAndIdentificationData)
        {
            
            _messageAndIdentificationData = messageAndIdentificationData;
        }      

        #region Objects
        private IWebElement MessageTextarea
        {
            get
            {
                return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Name("message")));
            }
        }
        private IWebElement ReturningCustomerTab
        {
            get
            {
                return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Id("checkout-returning")));
            }
        }
        private IWebElement EmailReturningCustomerTextbox
        {
            get
            {
                return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Name("auth_email")));
            }
        }
        private IWebElement PasswordReturningCustomerTextbox
        {
            get
            {
                return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Name("auth_password")));
            }
        }
        private IWebElement NewCustomerTab
        {
            get
            {
                return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Id("personal-msg-form")));
            }
        }
        private IWebElement NameCustomerTextbox
        {
            get
            {
                return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Id("name")));
            }
        }
        private IWebElement EmailCustomerTextbox
        {
            get
            {
                return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Id("email")));
            }
        }
        private IWebElement NextButton
        {
            get
            {   
                return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.CssSelector("#personalmesssage > input.btn.blue-btn.shadow")));
            }
        }
        private IWebElement BlockedNotification
        {
            get { return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(By.TagName("h6"))); }
        }
        private IWebElement TabNewCustomer
        {
            get
            {
                return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Id("personal-msg-form")));
            }
        }
        private IWebElement TabReturningCustomer
        {
            get
            {
                return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Id("checkout-returning")));
            }
        }
        private IWebElement CurrencySelect
        {
            get
            {
                return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Id("g-currency-switch")));
            }
        }

        private IWebElement TitleAuthorization
        {
            get { return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("double"))); }
        }
        #endregion

        #region Methods

        public void ClearMessageField()
        {
            MessageTextarea.Clear();
        }
        public string EditMessage()
        {
            MessageTextarea.Clear();
            foreach (var paragraph in _messageAndIdentificationData.Message)
            {
                MessageTextarea.SendKeys(paragraph);
            }
             
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }

        public string AddTextToMessage(string textToMessage, string key)
        {
         //   MessageTextarea.Click();
            MessageTextarea.SendKeys(key);
            MessageTextarea.SendKeys(textToMessage);

            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }
        public string LoginNewCustomer()
        {
            NameCustomerTextbox.SendKeys(_messageAndIdentificationData.CustomerName);
            EmailCustomerTextbox.SendKeys(_messageAndIdentificationData.CustomerEmail);
            return System.Reflection.MethodBase.GetCurrentMethod().Name ;
        }
        public string LoginReturningCustomer()
        {
            ReturningCustomerTab.SendKeys(Keys.Enter);
            EmailReturningCustomerTextbox.SendKeys(_messageAndIdentificationData.CustomerEmail);
            PasswordReturningCustomerTextbox.SendKeys(_messageAndIdentificationData.CustomerPassword);
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }
        public string ComfirmForm()
        {
            NextButton.SendKeys(Keys.Enter);
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }

        public bool CheckingEmail()
        {
            return (BlockedNotification.Displayed);
        }

        public string ClickTabReturningCustomer()
        {
            TabReturningCustomer.Click();
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }
        public bool CheckActiveTab()
        {
            return (TabNewCustomer.GetAttribute("class").Contains("active"));
        }

        public void EditCurrency(string currencyName)
        {
            SelectElement currencyItem = new SelectElement(CurrencySelect);
            currencyItem.SelectByText(currencyName);
        }
        public bool IsActiveCurrency(string fieldName, string expectedCurrency)
        {
           // IWebElement element 
            SelectElement currencyItem = new SelectElement(CurrencySelect);
            var actualCurrency = currencyItem.SelectedOption.Text;
            return Price.CompareCurrencies(expectedCurrency, actualCurrency);
        }
        public bool IsAuthorizationBlockVisibled()
        {
            return TitleAuthorization.Displayed;
        }
        #endregion
    }
}
