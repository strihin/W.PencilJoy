using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PencilJoyTests.Pages
{
   class BagPage
    {
        private WebDriverWait _waitDriver;

        public BagPage() { }
        public BagPage(WebDriverWait waitDriver)
        {
            _waitDriver = waitDriver;          
        }

        #region Objects
        public IWebElement NextButton
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(
                "body > div.bg-wrapp > section > div > div.btns > a.btn.blue-btn.shadow.js-prevalidate-discount-code")));
             }
        }
        #endregion

        #region Methods
        
        public string GetBagPageTitle()
        {
            NextButton.SendKeys(Keys.Enter);
            return System.Reflection.MethodBase.GetCurrentMethod().Name ;
        }
        #endregion
    }
}
