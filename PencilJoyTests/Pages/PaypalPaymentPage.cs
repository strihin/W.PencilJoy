using System;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PencilJoyTests.BddCore;
using PencilJoyTests.Data;

namespace PencilJoyTests.Pages
{
    public class PaypalPaymentPage
    {
        
        
        public PaypalPaymentPage() { }

        #region Objects
        private IWebElement PreLoginButton
        {
            get { return Hooks.WaitDriver.Until(ExpectedConditions.ElementIsVisible(
                By.ClassName("baslLoginButtonContainer")));
            }
        }
        private IWebElement EmailInput
        {
            get
            {
                return Hooks.WaitDriver.Until(ExpectedConditions.ElementIsVisible(
                By.Name("login_email")));
            }
        }
        private IWebElement PasswordInput
        {
            get
            {
                return Hooks.WaitDriver.Until(ExpectedConditions.ElementIsVisible(
                    By.Name("login_password")));
            }
        }
        private IWebElement PostLoginButton
        {
            get
            {
                return Hooks.WaitDriver.Until(ExpectedConditions.ElementIsVisible(
                    By.Id("btnLogin")));
            }
        }
        private IWebElement PreloaderSpinner
        {
            get
            {
                return Hooks.WaitDriver.Until(ExpectedConditions.ElementIsVisible(
                    By.Id("preloaderSpinner")));
            }
        }
        private IWebElement ReviewUserInfoText
        {
            get { return Hooks.WaitDriver.Until(ExpectedConditions.ElementIsVisible(By.Id("reviewUserInfo"))); }
        }
        #endregion

        #region Methods
        public string FillFields(PaypalPaymentData paypalPaymentData)
        {
            try
            {
                PreLoginButton.Click();
          
                Hooks.WebDriver.SwitchTo().Frame(Hooks.WebDriver.FindElement(By.TagName("iframe")));
                EmailInput.SendKeys(paypalPaymentData.EmailPaypal);
                PasswordInput.SendKeys(paypalPaymentData.PasswordPaypal);
            
                PostLoginButton.Click();
                Hooks.WebDriver.SwitchTo().Window(Hooks.WebDriver.WindowHandles.Last());
            }
            catch (Exception e)
            {
                Assert.Fail("spinner crashed test "+ e.Message+ e.Source);
                
            }
            return System.Reflection.MethodBase.GetCurrentMethod().Name ;
        }
        #endregion
    }
}