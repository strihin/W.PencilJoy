using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PencilJoyTests.BddCore;

namespace PencilJoyTests.Pages
{
    class SuccessfulOrderPage
    {
       
        #region Objects
        private IWebElement OrderText
        {
            get { return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(By.TagName("h4"))); }
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
