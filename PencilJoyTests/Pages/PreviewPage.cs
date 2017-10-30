using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PencilJoyTests.Maths;

namespace PencilJoyTests.Pages
{
    class PreviewPage
    {
        private readonly WebDriverWait _waitDriver;

        private PreviewMaths previewMath { get; set; }

        private string randomCurrency { get; set; }
        public PreviewPage(WebDriverWait waitDriver, PreviewMaths previewMath)
        {
           _waitDriver = waitDriver;
           this.previewMath = previewMath;
        }

        #region Objects
       private IWebElement OrderButton
       {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.CssSelector("div.btns > div.btns-unit > a")));
            }
       }
        private IWebElement RemindMeLaterButton
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.CssSelector("div.btns > a.js-show-popup-rml")));
            }
        }
        private IWebElement EditBookButton
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.CssSelector("div.btns > a:nth-child(3)")));
            }
        }
        private IWebElement CurrencySelector
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("g-currency-switch")));
            }
        }
      
        #region Popup Objects
        private IWebElement EmailInputPopup
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("email")));
            }
        }
        private IWebElement MaxDaysBeforeCheckboxPopup
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.CssSelector("#form-remind > div:nth-child(7) label")));
            }
        }
        private IWebElement MinDaysBeforeCheckboxPopup
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.CssSelector("#form-remind > div:nth-child(8) label")));
            }
        }
        private IWebElement SubscribeNewsCheckboxPopup
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.CssSelector("div.subscribe-box  label")));
            }
        }
        private IWebElement DatePickerPopup
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("datepicker")));
            }
        }
        private IWebElement SubmitPopup
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.CssSelector("#form-remind > input.btn-previe")));
            }
        }
        private IWebElement ClosePopup
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("close-remind-form")));
            }
        }
        #endregion
        #endregion

        #region Methods
        public string GetPreviewPageTitle()
        {
           bool staleElem = true;
            while (staleElem)
            {
                try
                {
                    previewMath.PreviewPriceBook = OrderButton.Text;
                    OrderButton.SendKeys(Keys.Enter);
                    staleElem = false;
                }
                catch (StaleElementReferenceException e)
                {
                    staleElem = true;
                }
            }
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }

        public string EditBook()
        {
            EditBookButton.SendKeys(Keys.Enter);
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }

        public string RemindMeLater()
        {
            RemindMeLaterButton.SendKeys(Keys.Enter);
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }

      public string EditCurrency()
        {
            randomCurrency = previewMath.RandomCurrency();
            bool staleElement = true;
            while (staleElement)
            {
                try
                {
                    CurrencySelector.SendKeys(Keys.Enter);
                    SelectElement currencySelector = new SelectElement(CurrencySelector);
                    currencySelector.SelectByValue(randomCurrency);
                    staleElement = false;
                }
                catch (StaleElementReferenceException e)
                {
                    staleElement = true;
                }
            }
            previewMath.VerifyCurrencyInButton(OrderButton.Text);
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }
     
        #region Popup Methods

        public string RemindMeBefore55Days(string email)
        {
            EmailInputPopup.SendKeys(email);
             MaxDaysBeforeCheckboxPopup.Click();
            SubscribeNewsCheckboxPopup.Click();
            SubmitPopup.Click();
            ClosePopup.Click();
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }
        public string RemindMeBefore30Days(string email, string date)
        {
            EmailInputPopup.SendKeys(email);
            MinDaysBeforeCheckboxPopup.SendKeys(Keys.Enter);
            DatePickerPopup.SendKeys(date);
            SubscribeNewsCheckboxPopup.SendKeys(Keys.Enter);
            SubmitPopup.SendKeys(Keys.Enter);
            ClosePopup.SendKeys(Keys.Enter);
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }
        #endregion
        #endregion
    }
}
