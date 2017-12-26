using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using PencilJoyTests.Data;
using PencilJoyTests.Maths;
using RazorEngine.Compilation.ImpromptuInterface;

namespace PencilJoyTests.Pages
{
   class BagPage
    {
        private WebDriverWait _waitDriver;
        private BagMaths _bagMath { get; set; }
        private  BagPageData _bagPageData {get; set; }
        private string randomCurrency { get; set; }
        private int numberEditBook { get; set; }
        private int numberRemoveBook { get; set; }
        private string discountCode { get; set; }
        private int bookAmountBeforeRemoving { get; set; }
        
     //   public BagPage() { }
        public BagPage(WebDriverWait waitDriver, BagMaths bagMath, BagPageData bagPageData)
        {
            _waitDriver = waitDriver;
            _bagMath = bagMath;
            _bagPageData = bagPageData;
        }

       public BagPage()
       {
         //  PageFactory.InitElements(Browser.Current, this);
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

       private IReadOnlyCollection<IWebElement> ActualGeneralDiscountCodes
       {
           get { return TablePrice.FindElements(By.XPath(".//*[text()='discount for']")); }
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

       private IWebElement TitleEmptyBag
       {
           get { return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.TagName("h2"))); }
       }
       private IWebElement ButtonContinueShopping
       {
           get { return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("emp-cart"))); }
       }

       private IWebElement LinkBasket
       {
           get { return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("active"))); }
       }

       private IWebElement DiscountIsAvailable
       {
           get { return DiscountRow.FindElement(By.XPath(".//*[text()='%']")); }
       }
       
       private IWebElement DiscountRow
       {
            get { return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("discount-row"))); }
       }

        #endregion

        #region Methods
        public string ConfirmForm()
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

       public void EnterDiscountCode(string DiscountCode)
       {
           DiscountCodeInput.SendKeys(DiscountCode);
       }

       public void ConfirmDiscountCode()
       {
           DiscountCodeButton.SendKeys(Keys.Enter);
       }

       public bool CheckDiscount()
       {
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
       public string EditBook(int number)
       {
           numberEditBook = number; // Faker.RandomNumber.Next(1,Products.Count);
           EditBookLink.Click();
           return System.Reflection.MethodBase.GetCurrentMethod().Name;
       }
       public string RemoveBook(int numberBook)
       {
           bookAmountBeforeRemoving = Products.Count;
           numberRemoveBook = numberBook; //Faker.RandomNumber.Next(1, Products.Count);
           RemoveBookLink.Click();
           return System.Reflection.MethodBase.GetCurrentMethod().Name;
       }
       public string AcceptRemovingBook(IWebDriver _webDriver)
       {
           _webDriver.SwitchTo().Alert().Accept();
           return System.Reflection.MethodBase.GetCurrentMethod().Name;
       }

       public string RemoveAllBooks(IWebDriver _webDriver)
       {
           for(int i = 0; i < Products.Count; i++)
           {
               RemoveBook(i + 1);
               AcceptRemovingBook(_webDriver);
           }
       }

       public bool VerifyBooksAmount(int expectedAmountBooks)
       {
           return (expectedAmountBooks != Products.Count) ? true : false;
       }
       public void GetBagPriceBagMath()
       {
          // if(VerifyBooksAmount())
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

       public bool VerifyGeneralDiscountCodes(int expectedNumberBook, int expectedPercentBook)
       {
           List<int> actualDiscountCodes = ConvertDiscountCodes();
           bool isEmptyList = !actualDiscountCodes.Any();
           if (expectedPercentBook == 0 && (isEmptyList))
           {
               return true;
           }
           else
           {
                for (int i = 0; i < actualDiscountCodes.Count; i++)
               {
                   if (expectedNumberBook - 2 == i)
                   {
                       if (actualDiscountCodes[i] == expectedPercentBook)
                           return true;
                   }
               }
               return false;
           }
       }
       public List<int> ConvertDiscountCodes()
       {
           List<int> discountDecimalList = new List<int>();
           List<IWebElement> discountStringsList = new List<IWebElement>(ActualGeneralDiscountCodes);

           foreach (var discountString  in discountStringsList)
           {
               discountDecimalList.Add(Convert.ToInt32(discountStringsList[0].Text.Substring(0, discountStringsList[0].Text.IndexOf(' ')-1)));
           }
           return discountDecimalList;
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
       public bool CheckBasketAsEmpty()
       {
           return (Products.Count != 0) ? true : false;
       }

       public bool CheckTheButtonIsVisible()
       {
           return TitleEmptyBag.Displayed ? true : false;
       }

       public void ContinueShopping()
       {
           ButtonContinueShopping.Click();
       }

       public bool VerifyCountBooks()
       {
           return (bookAmountBeforeRemoving - Products.Count == 1);
       }

       public bool IsAlertExists(IWebDriver _webDriver)
       {
           try
           {
               _webDriver.SwitchTo().Alert();
               return true;
           }   
           catch (NoAlertPresentException Ex)
           {
               return false;
           }  
       }

       public bool IsBasketEmpty()
       {
           return (LinkBasket.Text=="Bag ")?
               true : false;
       }

       public bool IsCodeValid(int expectedPercent)
       {
           int actualPercent = 0;
           if (DiscountIsAvailable.Enabled)
           {
               actualPercent = Convert.ToInt32(Regex.Match(DiscountIsAvailable.Text, @"\d+").Value);
           }

           return (actualPercent == expectedPercent);
       }

       public bool IsCodeUnchecked()
       {
           return Helper.SearchErrorField(DiscountRow);
       }
        #endregion
    }
}
