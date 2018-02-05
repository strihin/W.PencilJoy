using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PencilJoyTests.BddCore;
using PencilJoyTests.Data;

namespace PencilJoyTests.Pages
{
    class EditBookPage : CreateBookPage
    {
       

        private CreateBookData _createBookData;

        public EditBookPage(CreateBookData createBookData) : base(createBookData) { }
        public EditBookPage() { }

        #region Objects
        private IWebElement UpdateChangeButton
        {
            get
            {
                return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#create-child > div.cc-block.submit > input[type='submit']")));
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
