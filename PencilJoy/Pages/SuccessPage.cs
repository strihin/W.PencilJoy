using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace PencilJoy.Pages
{
    class SuccessPage
    {
        IWebDriver webDriver;

        public SuccessPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        #region Objects
        private IWebElement SuccessfullCheckoutForm
        {
            get
            {
                return webDriver.FindElement(By.ClassName("form-msg"));
            }
        }
       
        public IWebElement GetElement(By locator)
        {
            List<IWebElement> elements = webDriver.FindElements(locator).ToList();
            if (elements.Count > 0)
            {
                return elements[0];
            }
            return null;
        }
      
        public string CheckSuccessForm()
        {
            IWebElement Success = GetElement(By.ClassName("btnlogin"));
            string SuccessPageTitle = webDriver.Title;

            return SuccessPageTitle;
        }
        #endregion
    }
}
