using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using PencilJoyTests.Maths;
using PencilJoyTests.Pages;
using TechTalk.SpecFlow;

namespace PencilJoyTests.BddCore.Steps
{
    [Binding]
    public class EqualPriceAndDiscountValueOnDifferentStepsOfOrderSteps
    {
        private IWebDriver currentDriver;
        internal CreateBookPage bookPage = new CreateBookPage();
        internal PreviewPage previewPage = new PreviewPage();
        internal BagPage bagPage = new BagPage();
        internal MessageAndIdentificationPage messagePage = new MessageAndIdentificationPage();
        internal CheckoutPaymentPage ChPaymentPage = new CheckoutPaymentPage();
        internal FooterPage footerPage = new FooterPage();

        private PreviewMaths previewMaths = new PreviewMaths();
        private BagMaths bagMaths = new BagMaths();
        private CheckoutMaths checkoutMaths = new CheckoutMaths();
        private MathResults mathResults = new MathResults();
        

        [Given(@"The user clicks the button  Order")]
        public void GivenTheUserClicksTheButtonOrder()
        {
            previewPage.ConfirmGeneralForm();
        }
        
        [Given(@"The user clicks the button Next on the message page")]
        public void GivenTheUserClicksTheButtonNextOnTheMessagePage()
        {
            messagePage.ComfirmForm();
        }
        
        [Given(@"The user clicks the button Next")]
        public void GivenTheUserClicksTheButtonNExt()
        {
            bagPage.ConfirmForm();
        }
        
        [Given(@"The user enters correct discount code as (.*)")]
        public void GivenTheUserEntersCorrectDiscountCodeAs(string code)
        {
            bagPage.EnterDiscountCode(code);
        }

        [Given(@"The user gets discount percent and name for order on the bag page as (.*)")]
        public void GivenTheUserGetsDiscountPercentAndNameForOrderOnTheBagPageAs(int expectedPercent)
        {
            bagPage.IsCodeValid(expectedPercent);
        }

        [When(@"The user adds few books in the bag")]
        [Given(@"The user adds few books in the bag")]
        public void GivenTheUserAddsFewBooksInTheBag()
        {
            int howMuch = 3;
            for ( int i = 0; i < howMuch; i++)
            {
                bagPage.ShopMoreBooks();
                bookPage.LoginIntoBookData("test "+i, 1, 4, 0, 4);
                previewPage.ConfirmGeneralForm();
                messagePage.AddTextToMessage("text to the message", "two");
                // if block for auth invis, confirm form, else fill fields
                if (messagePage.IsAuthorizationBlockVisibled())
                {
                    messagePage.LoginNewCustomer();
                }
                messagePage.ComfirmForm();
            }
         
        }
        
        [Given(@"The user gets currency from totalprice")]
        public double GivenTheUserGetsCurrencyFromTotalprice()
        {
            var totalPrice = Helper.ActualOrder.SubtotalPrice;
            return totalPrice;
        }

        [When(@"The user gets price for the first book")]
        [Given(@"The user saves price book on the bag page")]
        public List<double> GivenTheUserSavesPriceBookOnTheBagPage()
        {
            List<double> listBook = Helper.ActualOrder.PriceBook;
            List<double> listBookN = Helper.ActualOrder.PriceBook;
            return listBook;
        }
        [Given(@"The user gets price and currency for a book from the button  Order on the preview page")]
        public Price GivenTheUserGetsPriceAndCurrencyForABookFromTheButtonOrderOnThePreviewPage()
        {
            
            double previewBookPrice = previewPage.GetPriceForBook(); 
            string previewBookCurrency = previewPage.GetCurrencyForBook();
            return new Price(previewBookPrice, previewBookCurrency);
        }
        [Given(@"The user gets price and currency for the first book on the bag page")]
        public Price GivenTheUserGetsPriceAndCurrencyForTheFirstBookOnTheBagPage()
        {
            double previewBookPrice = bagPage.GetFirstPriceBook();
            string previewBookCurrency = previewPage.GetCurrencyForBook();
            return new Price(previewBookPrice, previewBookCurrency);
        }
        [Given(@"The user gets price and currency for the totalprice on the bag page")]
        public Price GivenTheUserGetsPriceAndCurrencyForTheTotalpriceOnTheBagPage()
        {

            double bagTotalPrice = bagPage.GetFirstPriceBook();
            string bagTotalCurrency = previewPage.GetCurrencyForBook();
            return new Price(bagTotalPrice, bagTotalCurrency);
        }

        [When(@"The user gets discount percent and name for order on the checkout page as (.*)  (.*)")]
        public void WhenTheUserGetsDiscountPercentAndNameForOrderOnTheCheckoutPageAs(string expectedCodeName, string expectedCodeVal)
        {
            ChPaymentPage.AreEqualPrices(expectedCodeName, expectedCodeVal);
        }

        [When(@"The user gets price for the first book")]
        [When(@"The user gets price and currency  for the first book on the bag page")]
        public double WhenTheUserGetsPriceAndCurrencyForTheFirstBookOnTheBagPage()
        {
            return Convert.ToDouble(bagMaths.VerifyCurrencyInTheFirstBook());
        }
        
        [When(@"The user gets  price and currency for the first book on the checkout page")]
        public Price WhenTheUserGetsPriceAndCurrencyForTheFirstBookOnTheCheckoutPage()
        {
            double priceFirstBook = WhenTheUserGetsPriceAndCurrencyForTheFirstBookOnTheBagPage();
            string currencyFirstBook = bagMaths.VerifyCurrencyInTheFirstBook();

            return new Price(priceFirstBook, currencyFirstBook);
        }
        
        [When(@"The user gets  price and currency for the totalprice on the checkout page")]
        public double WhenTheUserGetsPriceAndCurrencyForTheTotalpriceOnTheCheckoutPage()
        {
          //  var totalPrice = checkoutMaths.CheckoutGrandPrice;
            double totalPrice = Helper.ActualOrder.GrandPrice;
            return totalPrice;
        }
        
        [When(@"The user gets price for booklist on the checkout page")]
        public List<double> WhenTheUserGetsPriceForBooklistOnTheCheckoutPage()
        {
            List<double> CheckoutPriceBookList = Helper.ActualOrder.PriceBook;
            return CheckoutPriceBookList;
        }
        
        [When(@"The user gets currency for totalprice on the checkout page")]
        public double WhenTheUserGetsCurrencyForTotalpriceOnTheCheckoutPage()
        {
            double totalPrice = Helper.ActualOrder.GrandPrice;
            return totalPrice;
        }
        
        [When(@"The user changes currency for order as ""(.*)""")]
        public void WhenTheUserChangesCurrencyForOrderAs(string currency)
        {
            bagPage.EditCurrency(currency);
        }
        
        [When(@"The user clicks button Ok on the popup notification for removing")]
        public void WhenTheUserClicksButtonOkOnThePopupNotificationForRemoving()
        {
            bagPage.AcceptRemovingBook(currentDriver);
        }
        
        [Then(@"The price and currency for a book on the bag page and  on the checkout page should be equal")]
        public void ThenThePriceAndCurrencyForABookOnTheBagPageAndOnTheCheckoutPageShouldBeEqual()
        {
            Price bagPrice = new Price(WhenTheUserGetsPriceAndCurrencyForTheFirstBookOnTheBagPage(), bagMaths.VerifyCurrencyInTheFirstBook());
            Price checkoutPrice = WhenTheUserGetsPriceAndCurrencyForTheFirstBookOnTheCheckoutPage();

            Assert.IsTrue(bagPrice.ComparePrices(bagPrice, checkoutPrice));
        }

        [Then(@"The price and currency for a book on the preview page and on the bag page should be equal")]
        public void ThenThePriceAndCurrencyForABookOnThePreviewPageAndOnTheBagPageShouldBeEqual()
        {
            Price previewPrice = GivenTheUserGetsPriceAndCurrencyForABookFromTheButtonOrderOnThePreviewPage();
            Price bagPrice = new Price(bagPage.GetFirstPriceBook(), bagPage.GetActiveCurrency());
            Assert.IsTrue(previewPrice.ComparePrices(previewPrice, bagPrice));

        }

        [Then(@"The price and currency for the totalprice on the bag page and on the checkout page should be equal")]
        public void ThenThePriceAndCurrencyForTheTotalpriceOnTheBagPageAndOnTheCheckoutPageShouldBeEqual()
        {
            double checkoutTotalprice = WhenTheUserGetsPriceAndCurrencyForTheTotalpriceOnTheCheckoutPage();
            string checkoutCurrency = "";
        }
        
        [Then(@"The discount percent and name for order should be equal on the bag page and on the checkout page")]
        public void ThenTheDiscountPercentAndNameForOrderShouldBeEqualOnTheBagPageAndOnTheCheckoutPage()
        {
            DiscountCode discountCodeBag = new DiscountCode(bagPage.DiscountCode, bagPage.DiscountName);
            DiscountCode discountCodeCheckout = ChPaymentPage.GetDiscountCode();

            Assert.IsTrue((discountCodeCheckout.CompareDiscountCodes(discountCodeCheckout, discountCodeBag)));
        }
        
        [Then(@"The price for every book should be equal counted values")]
        [Then(@"The user compares price books on the bag page and the checkout page, they should be equal")]
        [Then(@"The price for booklist should be equal on the bag page and on the checkout page")]
        public void ThenThePriceForBooklistShouldBeEqualOnTheBagPageAndOnTheCheckoutPage()
        {
            checkoutMaths.ComparePriceBookLists();
        }
        
        [Then(@"The currency for totalprice should be equal on the bag page and on the checkout page")]
        public void ThenTheCurrencyForTotalpriceShouldBeEqualOnTheBagPageAndOnTheCheckoutPage()
        {
            checkoutMaths.CompareUnitPrice();
        }
        
        [Then(@"The price for the first book with  should be equal as (.*)")]
        public void ThenThePriceForTheFirstBookWithShouldBeEqualAs(double price)
        {
            Assert.IsTrue(bagMaths.ComparePriceInTheFirstBook(price));
        }
        
        [Then(@"The price for the order should be subtracted price for removing book\.")]
        public void ThenThePriceForTheOrderShouldBeSubtractedPriceForRemovingBook_()
        {
            bagMaths.CalculateTotalPriceInBag();
            Assert.IsTrue(Helper.checkSubtotalPrice);
        }
    }
}
