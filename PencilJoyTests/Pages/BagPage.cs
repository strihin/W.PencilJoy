using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using PencilJoyTests.Data;
using PencilJoyTests.Math;
using RazorEngine.Compilation.ImpromptuInterface;

namespace PencilJoyTests.Pages
{
   class BagPage
    {
        private WebDriverWait _waitDriver;
        private BagMath _bagMath { get; set; }
        private  BagPageData _bagPageData {get; set; }
        private string randomCurrency { get; set; }
        private int numberEditBook { get; set; }
        private int numberRemoveBook { get; set; }
        private string discountCode { get; set; }
        public BagPage() { }
        public BagPage(WebDriverWait waitDriver, BagMath bagMath, BagPageData bagPageData)
        {
            _waitDriver = waitDriver;
            _bagMath = bagMath;
            _bagPageData = bagPageData;
        }

        #region Objects
        private IWebElement EditBookLink
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("tr:nth-child("+numberEditBook+") a.edit")));
            }
        }
        private IWebElement RemoveBookLink
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("tr:nth-child(" + numberRemoveBook + ") a.delete")));
            }
        }
        private IWebElement DiscountCodeInput
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Name("discount-code")));
            }
        }
        private IWebElement DiscountCodeButton
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("js-discount-check")));
            }
        }
        private IWebElement CurrencySelector
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Id("currency-switch")));
            }
        }
        private IWebElement NextButton
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("js-prevalidate-discount-code")));
            }
        }
        private IWebElement ShopMoreBooksButton
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("green-btn")));
            }
        }

       private IWebElement TablePrice
       {
           get
           {
               return _waitDriver.Until(ExpectedConditions.ElementToBeClickable
                   (By.CssSelector("table:nth-child(1) > tbody")));
           }
       }

       private IWebElement DisountPercent
       {
           get { return  _waitDriver.Until(ExpectedConditions.ElementToBeClickable
               (By.XPath(".//tbody/tr/td[3]/b"))); }
       }
       private IReadOnlyCollection<IWebElement> Products
       {
           get
           {
               return TablePrice.FindElements(By.XPath(".//*[text()='Edit']/../.."));
           }
       }
       private List<IWebElement> Prices
       {
           get
           {
               IReadOnlyCollection<IWebElement> tempCollection =
               TablePrice.FindElements(By.XPath(".//*[text()='Edit']/../preceding-sibling::td[1]"));
               List<IWebElement> myList = new List<IWebElement>(tempCollection);
               return myList;
           }
       }

       private IWebElement SubTotalPrice
       {
           get { return TablePrice.FindElement(By.XPath(".//*[text()='Subtotal']/../following-sibling::td[1]")); }
       }
       private IWebElement GrandTotalPrice
       {
           get { return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//*[text()='Subtotal']/../following-sibling::td[1]"))); }
       }
        #endregion

        #region Methods
        public string GetCheckoutPage()
        {
            GetBagPriceBagMath();
            NextButton.SendKeys(Keys.Enter);
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }
       public string ShopMoreBooks()
       {
           ShopMoreBooksButton.SendKeys(Keys.Enter);
           return System.Reflection.MethodBase.GetCurrentMethod().Name;
       }

       public bool CheckDiscount()
       {
           DiscountCodeInput.SendKeys(_bagPageData.DiscountCode);
           DiscountCodeButton.SendKeys(Keys.Enter);

           return GetDiscountPercent();
       }
       public bool GetDiscountPercent()
       {
           if (DisountPercent.Enabled)
           {
               _bagMath.ActualOrder.DiscountCode = _bagMath.GetDigit(DisountPercent.Text);
               _bagMath.ExpectedOrder.DiscountCode = FullAdminData.DiscountCodeList.Find(item => item.CodeName == _bagPageData.DiscountCode).CodeValue;
               if (_bagMath.ActualOrder.DiscountCode == _bagMath.ExpectedOrder.DiscountCode)
               {
                   return true;
               }
               return false;
           }
           else
           {
               DiscountCodeInput.Clear();
               _bagMath.ExpectedOrder.DiscountCode = -1;
               return false;
           }
       }
       public string EditBook()
       {
           numberEditBook = Faker.RandomNumber.Next(1,Products.Count);
           EditBookLink.Click();
           return System.Reflection.MethodBase.GetCurrentMethod().Name;
       }
       public string RemoveBook(IWebDriver _webDriver)
       {
           numberRemoveBook = Faker.RandomNumber.Next(1, Products.Count);
           RemoveBookLink.Click();
           _webDriver.SwitchTo().Alert().Accept();
           return System.Reflection.MethodBase.GetCurrentMethod().Name;
       }

       public void GetBagPriceBagMath()
       {
           GetActualPriceBook();
           _bagMath.ActualOrder.CurrencySymbol = _bagMath.GetCurrency(GrandTotalPrice.Text, _bagMath.VerifyPriceInTheFirstBook());
           _bagMath.ActualOrder.DiscountCode = _bagMath.GetDiscount(DisountPercent.Text);

           _bagMath.VerifyActionForListBook();
           
           // +checking correctly currency
           _bagMath.ExpectedOrder.SubtotalPrice = _bagMath.ConvertTotalPrice(SubTotalPrice.Text, _bagMath.VerifyPriceInTheFirstBook());
           _bagMath.ExpectedOrder.GrandPrice = _bagMath.ConvertTotalPrice(GrandTotalPrice.Text, _bagMath.VerifyPriceInTheFirstBook());
           _bagMath.ExpectedOrder.CurrencySymbol = Converter.ActualCurrency;
           _bagMath.VerifyActionForListBook();
           _bagMath.CalculateTotalPriceInBag();
        
       }
       public string EditCurrency()
       {
           bool staleElement = true;
           SelectElement currencyItem = new SelectElement(CurrencySelector);
         
           while (staleElement)
           {
               try
               {
                   CurrencySelector.Click();
                   currencyItem.SelectByValue(randomCurrency); ;
                   staleElement = false;
               }
               catch (StaleElementReferenceException e)
               {
                   staleElement = true;
               }
           }
           return System.Reflection.MethodBase.GetCurrentMethod().Name;
       }
       #region GetPrice
       public void GetActualPriceBook()
       {
           List<double> priceArr = new List<double>();

           foreach (var price in Prices)
           {
               priceArr.Add(Convert.ToDouble(_bagMath.RemoveOldPrice(price.Text)));
           }
           _bagMath.ExpectedOrder.PriceBook = priceArr;
       }
        #endregion
       public string test()
       {
        //   var q = GetDiscountPercent();
           
           return System.Reflection.MethodBase.GetCurrentMethod().Name;
       }
        #endregion
    }
}
