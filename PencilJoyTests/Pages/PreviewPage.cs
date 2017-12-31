using System.Collections.Generic;
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

        public PreviewPage() { }
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
        private IWebElement PopupRemindMeLater
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.ClassName("remind-wrapper")));
            }
        }
        private IWebElement PopupRemindSet
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.ClassName("close-remind-form")));
            }
        }
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
        private IWebElement DatePickerField
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("datepicker")));
            }
        }

        private IWebElement DatePickerPopup
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("datepicker-days")));
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
                    By.Id("rw-content-success")));
            }
        }
        private IWebElement ErrorMessage
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.ClassName("rem-error")));
            }
        }

        private IWebElement EmailReminder
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("teleport")));
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
        public string RemindMeLater()
      {
          RemindMeLaterButton.SendKeys(Keys.Enter);
          return System.Reflection.MethodBase.GetCurrentMethod().Name;
      }

        public bool IsButtonContainSymbolCurrency(string currency)
        {
            return OrderButton.Text.Contains(currency);
        }
     
        #region Popup Methods

        public string FillEmailToPopup(string email)
        {
            EmailInputPopup.SendKeys(email);
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }

        public string SelectCheckbox(string cbText)
        {
            switch (cbText)
            {
                case "55 days before December 25th":
                    MaxDaysBeforeCheckboxPopup.Click();
                    break;
                case "30 days before":
                    MinDaysBeforeCheckboxPopup.Click();
                    break;
                case "Subscribe to news and special deals":
                    SubscribeNewsCheckboxPopup.Click();
                    break;
            }
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }
      
        public string CofirmFormInPopupRemindMeLater()
        {
            SubmitPopup.Click();
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }

        public string ClosePopupRemindMeLater()
        {
            ClosePopup.Click();
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }

        public bool IsPopupRemindSetDisplayed()
        {
            return PopupRemindSet.Displayed;
        }

        public bool IsEmailValid()
        {
            return Helper.SearchErrorField(EmailInputPopup);
        }

        public bool IsDataPickerDisplayed()
        {

            return DatePickerPopup.Displayed;
        }

        public bool IsPopupRemindMeLaterAppear()
        {
            return PopupRemindMeLater.Displayed;
        }
        public bool IsSuccessPopupAppear()
        {
            return ClosePopup.Displayed;
        }

        public bool IsMessageError(string textMessage)
        {
            return ErrorMessage.Text== textMessage;
        }

        public bool IsEmailCorrect(string email)
        {
            return EmailReminder.Text == email;
        }

        public void FillDatePicker()
        {
            string date = "01/30/2018";
            DatePickerField.SendKeys(date);

        }

        #endregion
#endregion
    }
}
