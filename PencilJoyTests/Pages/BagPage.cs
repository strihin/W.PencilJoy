using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PencilJoyTests.BddCore;
using PencilJoyTests.Data;
using PencilJoyTests.Maths;

namespace PencilJoyTests.Pages
{
   class BagPage : FooterPage
    {
        
        private BagMaths _bagMath { get; set; }
        private  BagPageData _bagPageData {get; set; }
        private string randomCurrency { get; set; }
        private int numberEditBook { get; set; }
        private int numberRemoveBook { get; set; }
        internal string DiscountName { get; set; }
        internal int DiscountCode { get; set; }
        private int bookAmountBeforeRemoving { get; set; }
        
     //   public BagPage() { }
        public BagPage(BagMaths bagMath, BagPageData bagPageData)
        {
            
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
                return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("tr:nth-child("+numberEditBook+") a.edit")));
            }
        }
        private IWebElement RemoveBookLink
        {
            get
            {
                return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("tr:nth-child(" + numberRemoveBook + ") a.delete")));
            }
        }
        private IWebElement DiscountCodeInput
        {
            get
            {
                return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Name("discount-code")));
            }
        }
        private IWebElement DiscountCodeButton
        {
            get
            {
                return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("js-discount-check")));
            }
        }
        private IWebElement CurrencySelector
        {
            get
            {
                return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Id("currency-switch")));
            }
        }
        private IWebElement NextButton
        {
            get
            {
                return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("js-prevalidate-discount-code")));
            }
        }
        private IWebElement ShopMoreBooksButton
        {
            get
            {
                return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("green-btn")));
            }
        }

       private IWebElement TablePrice
       {
           get
           {
               return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable
                   (By.CssSelector("table:nth-child(1) > tbody")));
           }
       }

       private IWebElement DisountPercent
       {
           get { return  Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable
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
           get { return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//*[text()='GRAND total']/../following-sibling::td[1]"))); }
       }

       private IWebElement TitleEmptyBag
       {
           get { return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(By.TagName("h2"))); }
       }
       private IWebElement ButtonContinueShopping
       {
           get { return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("emp-cart"))); }
       }

       private IWebElement LinkBasket
       {
           get { return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("active"))); }
       }

       private IWebElement DiscountIsAvailable
       {
           get { return DiscountRow.FindElement(By.XPath(".//*[text()='%']")); }
       }
       
       private IWebElement DiscountRow
       {
            get { return Hooks.WaitDriver.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("discount-row"))); }
       }
      
        #endregion

        #region Methods
        public string ConfirmForm()
        {
            GetBagPriceBagMath();
            NextButton.SendKeys(Keys.Enter);
            return MethodBase.GetCurrentMethod().Name;
        }
       public string ShopMoreBooks()
       {
           ShopMoreBooksButton.SendKeys(Keys.Enter);
           return MethodBase.GetCurrentMethod().Name;
       }

       public void EnterDiscountCode(string DiscountCode)
       {
           DiscountCodeInput.SendKeys(DiscountCode);
           DiscountName = DiscountCode;

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
               Helper.ActualOrder.DiscountCode = _bagMath.GetDigit(DisountPercent.Text);
               Helper.ExpectedOrder.DiscountCode = FullAdminData.DiscountCodeList.Find(item => item.CodeName == _bagPageData.DiscountCode).CodeValue;
               if (Helper.ActualOrder.DiscountCode == Helper.ExpectedOrder.DiscountCode)
               {
                   return true;
               }
               return false;
           }
           else
           {
               DiscountCodeInput.Clear();
               Helper.ExpectedOrder.DiscountCode = -1;
               return false;
           }
       }
       public string EditBook(int number)
       {
           numberEditBook = number; // Faker.RandomNumber.Next(1,Products.Count);
           EditBookLink.Click();
           return MethodBase.GetCurrentMethod().Name;
       }
       public string RemoveBook(int numberBook)
       {
           bookAmountBeforeRemoving = Products.Count;
           numberRemoveBook = numberBook; //Faker.RandomNumber.Next(1, Products.Count);
           RemoveBookLink.Click();
           return MethodBase.GetCurrentMethod().Name;
       }
       public string AcceptRemovingBook()
       {
           Hooks.WebDriver.SwitchTo().Alert().Accept();
           return MethodBase.GetCurrentMethod().Name;
       }

       public void RemoveAllBooks()
       {
           for(int i = 0; i < Products.Count; i++)
           {
               RemoveBook(i + 1);
               AcceptRemovingBook();
           }
       }

       public bool VerifyBooksAmount(int expectedAmountBooks)
       {
           return (expectedAmountBooks != Products.Count);
       }
       public void GetBagPriceBagMath()
       {
           GetActualPriceBook();
           Helper.ActualOrder.CurrencySymbol = _bagMath.GetCurrency(GrandTotalPrice.Text, _bagMath.GetFirstBookPrice());
           Helper.ActualOrder.DiscountCode = _bagMath.GetDiscount(DisountPercent.Text);

           _bagMath.VerifyActionForListBook();
           
           // +checking correctly currency
           Helper.ExpectedOrder.SubtotalPrice = _bagMath.ConvertTotalPrice(SubTotalPrice.Text, _bagMath.VerifyCurrencyInTheFirstBook());
           Helper.ExpectedOrder.GrandPrice = _bagMath.ConvertTotalPrice(GrandTotalPrice.Text, _bagMath.VerifyCurrencyInTheFirstBook());
           Helper.ExpectedOrder.CurrencySymbol = Converter.ActualCurrency;
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
       
       //public string EditCurrency()
       //{
       //    bool staleElement = true;
       //    SelectElement currencyItem = new SelectElement(CurrencySelector);
         
       //    while (staleElement)
       //    {
       //        try
       //        {
       //            CurrencySelector.Click();
       //            currencyItem.SelectByValue(randomCurrency); ;
       //            staleElement = false;
       //        }
       //        catch (StaleElementReferenceException e)
       //        {
       //            staleElement = true;
       //        }
       //    }
       //    return System.Reflection.MethodBase.GetCurrentMethod().Name;
       //}

       public string GetActiveCurrency()
       {
           SelectElement currencyItem = new SelectElement(CurrencySelector);
           return currencyItem.SelectedOption.Text;
       }

       public void EditCurrency(string currencyName)
       {
           SelectElement currencyItem = new SelectElement(CurrencySelector);
           currencyItem.SelectByText(currencyName);
       }
       public bool IsActiveCurrency(string currency)
       {
           return CurrencySelector.Text == currency;
       }
       #region GetPrice
       public void GetActualPriceBook()
       {
           List<double> priceArr = new List<double>();

           foreach (var price in Prices)
           {
               priceArr.Add(Convert.ToDouble(_bagMath.RemoveOldPrice(price.Text)));
           }
           Helper.ExpectedOrder.PriceBook = priceArr;

       }
       public double GetFirstPriceBook()
       {
           List<double> priceArr = new List<double>();

           foreach (var price in Prices)
           {
               priceArr.Add(Convert.ToDouble(_bagMath.RemoveOldPrice(price.Text)));
           }
           return priceArr[0];
       }
        #endregion
       public bool CheckBasketAsEmpty()
       {
           return (Products.Count != 0);
       }

       public bool CheckTheButtonIsVisible()
       {
           return TitleEmptyBag.Displayed;
       }

       public void ContinueShopping()
       {
           ButtonContinueShopping.Click();
       }

       public bool VerifyCountBooks()
       {
           return (bookAmountBeforeRemoving - Products.Count == 1);
       }

       public bool IsAlertExists()
       {
           try
           {
               Hooks.WebDriver.SwitchTo().Alert();
               return true;
           }   
           catch (NoAlertPresentException Ex)
           {
               Console.WriteLine(Ex.Message+Ex.Data);
               return false;
           }  
       }

       public bool IsBasketEmpty()
       {
           return (LinkBasket.Text == "Bag ");
       }

       public bool IsCodeValid(int expectedPercent)
       {
           int actualPercent = 0;
           if (DiscountIsAvailable.Enabled)
           {
               actualPercent = Convert.ToInt32(Regex.Match(DiscountIsAvailable.Text, @"\d+").Value);
               DiscountCode = actualPercent;
           }
           return (actualPercent == expectedPercent);
       }

       public bool IsCodeUnchecked()
       {
           return Helper.SearchErrorField(DiscountRow);
       }
       
       public string GetBookDescriptionFromButton()
       {
           return DiscountRow.Text.Trim().Split(' ').Last();
       }
        #endregion
    }
}