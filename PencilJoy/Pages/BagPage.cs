using System;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace PencilJoy.Pages
{
    class BagPage
    {
        IWebDriver webDriver;

        public BagPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;          
        }

        #region Objects
        private IWebElement NextButton
        {
            get
            {
                return webDriver.FindElement(By.CssSelector("body > div.bg-wrapp > section > div > div.btns > a.btn.blue-btn.shadow.js-prevalidate-discount-code"));
            }
        }
        #endregion

        #region Methods
     
        public string GetBagPageTitle()
        {
            string BagPageTitle = webDriver.Title;
            NextButton.Click();
            return BagPageTitle;
        }
        #endregion
    }
}
