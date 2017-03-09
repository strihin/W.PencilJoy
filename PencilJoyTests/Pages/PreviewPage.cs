using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PencilJoyTests.Pages
{
    class PreviewPage
    {
        private readonly WebDriverWait _waitDriver;
        public PreviewPage(WebDriverWait waitDriver)
        {
           _waitDriver = waitDriver;
        }

        #region Objects
        private IWebElement OrderButton
       {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.PartialLinkText("ORDER FOR $29.99")));
            }
       }
        #endregion

        #region Methods
        public string GetPreviewPageTitle()
        {
            OrderButton.SendKeys(Keys.Enter);
            return System.Reflection.MethodBase.GetCurrentMethod().Name ;
           }
        #endregion
    }
}
