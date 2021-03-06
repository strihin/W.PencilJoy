﻿using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PencilJoyTests.Data;

namespace PencilJoyTests.Pages
{
    class MessageAndIdentificationPage
    {
        private WebDriverWait _waitDriver;
        private MessageAndIdentificationData _messageAndIdentificationData;

        public MessageAndIdentificationPage() { }
        public MessageAndIdentificationPage(WebDriverWait waitDriver, MessageAndIdentificationData messageAndIdentificationData)
        {
            _waitDriver = waitDriver;
            _messageAndIdentificationData = messageAndIdentificationData;
        }      

        #region Objects
        private IWebElement MessageTextarea
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Name("message")));
            }
        }
        private IWebElement ReturningCustomerTab
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Id("checkout-returning")));
            }
        }
        private IWebElement EmailReturningCustomerTextbox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Name("auth_email")));
            }
        }
        private IWebElement PasswordReturningCustomerTextbox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Name("auth_password")));
            }
        }
        private IWebElement NewCustomerTab
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Id("personal-msg-form")));
            }
        }
        private IWebElement NameCustomerTextbox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Id("name")));
            }
        }
        private IWebElement EmailCustomerTextbox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Id("email")));
            }
        }
        private IWebElement NextButton
        {
            get
            {   
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.CssSelector("#personalmesssage > input.btn.blue-btn.shadow")));
            }
        }
        private IWebElement BlockedNotification
        {
            get { return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.TagName("h6"))); }
        }
        #endregion

        #region Methods
        public string EditMessage()
        {
            MessageTextarea.Clear();
            foreach (var paragraph in _messageAndIdentificationData.Message)
            {
                MessageTextarea.SendKeys(paragraph);
            }
             
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
        public string NextStepToBag()
        {
            NextButton.SendKeys(Keys.Enter);
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }

        public bool CheckingEmail()
        {
            return (BlockedNotification.Displayed) ? true : false;
        }
        #endregion
    }
}
