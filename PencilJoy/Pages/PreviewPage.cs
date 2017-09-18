using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace PencilJoy.Pages
{
    class PreviewPage
    {
        IWebDriver webDriver;

        public PreviewPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
          
        }

        #region Objects
        private IWebElement OrderButton
       {
            get
            {
                return webDriver.FindElement(By.CssSelector("body > div.bg-wrapp > section.preview.container.bordered-section > div > div.btns > div.btns-unit > a"));
            }
       }
        #endregion

        #region Methods
        public string GetPreviewPageTitle()
        {
         
        //    WebDriverWait ww = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
         //   IWebElement txt = ww.Until(ExpectedConditions.ElementIsVisible(By.ClassName("btns-unit")));
          //  webDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            string PreviewPageTitle = webDriver.Title;
            OrderButton.Click();
            return PreviewPageTitle;
        }
        #endregion
    }
}
