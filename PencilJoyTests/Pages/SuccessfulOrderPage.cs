using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PencilJoyTests.Pages
{
    class SuccessfulOrderPage
    {
        private readonly WebDriverWait _waitDriver;

        public SuccessfulOrderPage(WebDriverWait _waitDriver)
        {
            this._waitDriver = _waitDriver;
        }
        #region Objects
        private IWebElement OrderText
        {
            get { return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.TagName("h4"))); }
        }
        #endregion

        #region Methods

        public string GetOrderNumber()
        {
            return OrderText.Text.Split(' ').ToList()[3];

        }
        #endregion
    }
}
