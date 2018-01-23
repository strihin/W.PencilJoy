﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PencilJoyTests.Data;
using PencilJoyTests.Maths;

namespace PencilJoyTests.Pages
{
    class CheckoutPaymentPage
    {

        private WebDriverWait _waitDriver;
        private CheckoutPaymentData checkoutPaymentData;
        private CheckoutMaths _checkoutMath;

        public CheckoutPaymentPage() { }
        public CheckoutPaymentPage(WebDriverWait waitDriver, CheckoutPaymentData checkoutPaymentData, CheckoutMaths checkoutMath)
        {
            this._waitDriver = waitDriver;
            this.checkoutPaymentData = checkoutPaymentData;
            _checkoutMath = checkoutMath;
        }
        #region Objects Payment
        private List<IWebElement> CreditCardInput
        { 
            get
            {
                IWebElement creditcard = _waitDriver.Until(ExpectedConditions.
                    ElementToBeClickable(By.ClassName("credit-input")));
                IReadOnlyCollection<IWebElement> tempCol =
                    creditcard.FindElements(By.XPath(".//input[@class='credit-cell']"));
                List<IWebElement> creditCard = new List<IWebElement>(tempCol);
                return creditCard;

            }
        }
        private IWebElement ExpirationMonthDropdown
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("select-month")));
            }
        }
        private IWebElement ExpirationYearDropdown
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("select-year")));
            }
        }
        private IWebElement CardVerifacationValueTextBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("cvn")));
            }
        }
        private IWebElement PlaceYourOrderButton
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Name("cardSubmit")));
            }
        }
        private IWebElement PaypalTab
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                     By.CssSelector("#payment-method > ul > li:nth-child(2) > a")));
            }
        }
        private IWebElement PaypalButton
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("pay-bth")));
            }
        }
        private List<IWebElement> PriceBookList
        {
            get
            {
                IWebElement tbody = _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//tbody")));
                IReadOnlyCollection<IWebElement> tempList = tbody.FindElements(By.XPath("//tr/td[2]"));
                List<IWebElement> priceBookList = new List<IWebElement>(tempList);
                return priceBookList;
            }
        }
        private IWebElement TotalPrice
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                            By.XPath(".//div[@class='cor-summary']/div[2]/span")));
            }
        }
        private IWebElement DiscountCodeField
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                            By.XPath("//*[@id='customer']/tbody/tr[2]")));
            }
        }

        private IWebElement PaymentError
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                            By.ClassName("payment-errors")));
            }
        }
        #endregion

        #region Methods

        public string SelectTabPaymentPaypal()
        {
            PaypalTab.SendKeys(Keys.Enter);
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }
        public string ConfirmPaypal()
        {
            PaypalButton.SendKeys(Keys.Enter);
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }
        public bool IsElementShown()
        {
            return PaypalButton.Displayed;
        }
        public string FillPaymentData(string creditCard, string cardVerification, int Month, int Year)
        {
            List<string> cardList = new List<string>();
         
            // convert credit card (string) to  4 sectors (list)
            for (int i = 0; i < CreditCardInput.Count; i+=4)
            {
                cardList.Add(creditCard.Substring(i,i+4));
            }
           // fill creditcard from list
            for (int i = 0; i < CreditCardInput.Count; i++)
            {
                CreditCardInput[i].SendKeys(cardList[i]);
            }
            ExpirationMonthDropdown.Click();
            SelectElement selectMonth = new SelectElement(ExpirationMonthDropdown);
            selectMonth.SelectByIndex(checkoutPaymentData.SelectMonth - 1);

            ExpirationYearDropdown.Click();
            SelectElement selectYear = new SelectElement(ExpirationYearDropdown);
            selectYear.SelectByIndex(checkoutPaymentData.SelectYear - 1);
            //  ExpirationYearDropitem.Click();
            CardVerifacationValueTextBox.SendKeys(checkoutPaymentData.CardVerifacationValue);

            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }
        public string ConfirmForm()
        {
            PlaceYourOrderButton.SendKeys(Keys.Enter);
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }

        public void GetActualPriceBook()
        {
            List<double> priceArr = new List<double>();
            string discountPercent = PriceBookList[PriceBookList.Count - 1].Text;
            int discountAvailable = 0;
        
            if (discountPercent.Contains('%'))
            {
                PriceBookList.RemoveAt(PriceBookList.Count - 1);
                Helper.ExpectedOrder.DiscountCode = _checkoutMath.GetDigit(discountPercent);
                discountAvailable++;
            }
            for (int i = 0; i < PriceBookList.Count - discountAvailable; i++)
            {
                priceArr.Add(Convert.ToDouble(_checkoutMath.RemoveOldPrice(PriceBookList[i].Text)));
            }
            Helper.ExpectedOrder.PriceBook = priceArr;
        }
        public void GetMathPriceForCheckoutMath()
        {
            GetActualPriceBook();

            Helper.ExpectedOrder.CurrencySymbol = _checkoutMath.GetCurrency(TotalPrice.Text, _checkoutMath.VerifyPriceInTheFirstBook());
            Helper.ExpectedOrder.GrandPrice = TotalPrice.Text.Contains("\r\n") ? _checkoutMath.ConvertTotalPrice(TotalPrice.Text.Replace("\r\n", " "),
            _checkoutMath.VerifyPriceInTheFirstBook()) : _checkoutMath.ConvertTotalPrice(TotalPrice.Text, _checkoutMath.VerifyPriceInTheFirstBook());

            _checkoutMath.VerifyPriceBook();
            _checkoutMath.VerifyDiscountCode();
            _checkoutMath.VerifyCurrency();
            _checkoutMath.VerifyGrandPrice();
        }
        public bool IsErrorDisplayed(string textError)
        {
            return PaymentError.Displayed && PaymentError.Text == textError;
        }

        public bool AreEqualPrices(string excpectedCodeName, string expectedCodeVal)
        {
            string actualCodeName = DiscountCodeField.FindElement(By.XPath("/td[1]")).Text;
            string actualCodeVal = DiscountCodeField.FindElement(By.XPath("/td[2]")).Text;
            actualCodeVal = actualCodeVal.Substring(1, actualCodeVal.Length - 2);
            actualCodeName = GetBookDescriptionFromButton(actualCodeName);

            return ((actualCodeVal == expectedCodeVal) && (actualCodeName == excpectedCodeName));
        }
        public string GetBookDescriptionFromButton(string code)
        {
            return code.Trim().Split(' ').Last();
        }

        public DiscountCode GetDiscountCode()
        {
            string actualCodeName = DiscountCodeField.FindElement(By.XPath("/td[1]")).Text;
            string actualCodeString = DiscountCodeField.FindElement(By.XPath("/td[2]")).Text;
            int actualCodeValue = Convert.ToInt32(Regex.IsMatch(actualCodeString, "^[0-9]*$"));

            actualCodeName = actualCodeName.Substring(1, actualCodeName.Length - 2);

            return new DiscountCode(actualCodeValue, actualCodeName);
        }
        #endregion
    }
}
