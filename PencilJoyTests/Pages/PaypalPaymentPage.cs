using System;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PencilJoyTests.Data;

namespace PencilJoyTests.Pages
{
    public class PaypalPaymentPage
    {
        private WebDriverWait _waitDriver;
        private IWebDriver webDriver;
        public PaypalPaymentPage() { }
        public PaypalPaymentPage(WebDriverWait waitDriver, IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            _waitDriver = waitDriver;          
        }

        #region Objects
        private IWebElement PreLoginButton
        {
            get { return _waitDriver.Until(ExpectedConditions.ElementIsVisible(
                By.ClassName("baslLoginButtonContainer")));
            }
        }

        private IWebElement EmailInput
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementIsVisible(
                By.Name("login_email")));
            }
        }

        private IWebElement PasswordInput
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementIsVisible(
                    By.Name("login_password")));
            }
        }

        private IWebElement PostLoginButton
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementIsVisible(
                    By.Id("btnLogin")));
            }
        }

        private IWebElement PreloaderSpinner
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementIsVisible(
                    By.Id("preloaderSpinner")));
            }
        }
        private IWebElement ReviewUserInfoText
        {
            get { return _waitDriver.Until(ExpectedConditions.ElementIsVisible(By.Id("reviewUserInfo"))); }
        }
        #endregion

        #region Methods

 
        public string FillFields(PaypalPaymentData paypalPaymentData)
        {
            try
            {
                PreLoginButton.Click();
               
          
                    webDriver.SwitchTo().Frame(webDriver.FindElement(By.TagName("iframe")));
              //  webDriver.SwitchTo().Frame(_waitDriver.Until(ExpectedConditions.ElementExists(By.TagName("iframe"))));
                EmailInput.SendKeys(paypalPaymentData.EmailPaypal);
                PasswordInput.SendKeys(paypalPaymentData.PasswordPaypal);
            
                PostLoginButton.Click();
                webDriver.SwitchTo().Window(webDriver.WindowHandles.Last());

        
            }
            catch (Exception e)
            {
                Assert.Fail("spinner crashed test");
                
            }
            return System.Reflection.MethodBase.GetCurrentMethod().Name ;
        }
        #endregion
    }
}