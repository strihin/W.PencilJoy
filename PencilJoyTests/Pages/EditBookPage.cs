using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PencilJoyTests.Data;

namespace PencilJoyTests.Pages
{
    class EditBookPage : CreateBookPage
    {
        private readonly WebDriverWait _waitDriver;

        private CreateBookData _createBookData;

        public EditBookPage(WebDriverWait waitDriver, CreateBookData createBookData) : base(waitDriver, createBookData) { }
        public EditBookPage() { }

        #region Objects
        private IWebElement UpdateChangeButton
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#create-child > div.cc-block.submit > input[type='submit']")));
            }
        }
        #endregion

        #region Methods
        public  string ConfirmForm()
        {
            UpdateChangeButton.Click();

            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }
        #endregion
    }
}
