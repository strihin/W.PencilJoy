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
        public void GivenTheUserGetsCurrencyFromTotalprice()
        {
            var totalPrice = bagMaths.ActualOrder.SubtotalPrice;
        }

        [When(@"The user gets price for the first book")]
        [Given(@"The user saves price book on the bag page")]
        public void GivenTheUserSavesPriceBookOnTheBagPage()
        {
            List<double> listBook = bagMaths.ActualOrder.PriceBook;
        }
        [Given(@"The user gets price and currency for a book from the button  Order on the preview page")]
        public void GivenTheUserGetsPriceAndCurrencyForABookFromTheButtonOrderOnThePreviewPage()
        {
            double previewBookPrice = previewPage.GetPriceForBook(); 
            string previewBookCurrency = previewPage.GetCurrencyForBook();
        }
        [Given(@"The user gets price and currency for the first book on the bag page")]
        public void GivenTheUserGetsPriceAndCurrencyForTheFirstBookOnTheBagPage()
        {
            double previewBookPrice = bagPage.GetFirstPriceBook();
            string previewBookCurrency = previewPage.GetCurrencyForBook();
        }
        [Given(@"The user gets price and currency for the totalprice on the bag page")]
        public void GivenTheUserGetsPriceAndCurrencyForTheTotalpriceOnTheBagPage()
        {

            double bagTotalPrice = bagPage.GetFirstPriceBook();
            string bagTotalCurrency = previewPage.GetCurrencyForBook();
        }

        [When(@"The user gets discount percent and name for order on the checkout page as (.*)  (.*)")]
        public void WhenTheUserGetsDiscountPercentAndNameForOrderOnTheCheckoutPageAs(int p0, int p1)
        {

        }

        [When(@"The user gets price for the first book")]
        [When(@"The user gets price and currency  for the first book on the bag page")]
        public double WhenTheUserGetsPriceAndCurrencyForTheFirstBookOnTheBagPage()
        {
            return bagMaths.VerifyPriceInTheFirstBook();
        }
        
        [When(@"The user gets  price and currency for the first book on the checkout page")]
        public void WhenTheUserGetsPriceAndCurrencyForTheFirstBookOnTheCheckoutPage()
        {
            double priceFirstBook = WhenTheUserGetsPriceAndCurrencyForTheFirstBookOnTheBagPage();
            string currencyFirstBook = bagMaths.VerifyCurrencyInTheFirstBook();
        }
        
        [When(@"The user gets  price and currency for the totalprice on the checkout page")]
        public void WhenTheUserGetsPriceAndCurrencyForTheTotalpriceOnTheCheckoutPage()
        {
            var totalPrice = checkoutMaths.CheckoutGrandPrice;
        }
        
        [When(@"The user gets price for booklist on the checkout page")]
        public void WhenTheUserGetsPriceForBooklistOnTheCheckoutPage()
        {
            List<double> CheckoutPriceBookList = checkoutMaths.ActualOrder.PriceBook;
        }
        
        [When(@"The user gets currency for totalprice on the checkout page")]
        public void WhenTheUserGetsCurrencyForTotalpriceOnTheCheckoutPage()
        {
            double totalPrice = checkoutMaths.ActualOrder.GrandPrice;
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
        
        [Then(@"The price and currency for a book on the preview page and on the bag page should be equal")]
        public void ThenThePriceAndCurrencyForABookOnThePreviewPageAndOnTheBagPageShouldBeEqual()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The price and currency for a book on the bag page and  on the checkout page should be equal")]
        public void ThenThePriceAndCurrencyForABookOnTheBagPageAndOnTheCheckoutPageShouldBeEqual()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The price and currency for the totalprice on the bag page and on the checkout page should be equal")]
        public void ThenThePriceAndCurrencyForTheTotalpriceOnTheBagPageAndOnTheCheckoutPageShouldBeEqual()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The discount percent and name for order should be equal on the bag page and on the checkout page")]
        public void ThenTheDiscountPercentAndNameForOrderShouldBeEqualOnTheBagPageAndOnTheCheckoutPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The price for every book should be equal counted values")]
        public void ThenThePriceForEveryBookShouldBeEqualCountedValues()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The price for booklist should be equal on the bag page and on the checkout page")]
        public void ThenThePriceForBooklistShouldBeEqualOnTheBagPageAndOnTheCheckoutPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The currency for totalprice should be equal on the bag page and on the checkout page")]
        public void ThenTheCurrencyForTotalpriceShouldBeEqualOnTheBagPageAndOnTheCheckoutPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The price for the first book with  should be equal as (.*)")]
        public void ThenThePriceForTheFirstBookWithShouldBeEqualAs(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The price for the order should be subtracted price for removing book\.")]
        public void ThenThePriceForTheOrderShouldBeSubtractedPriceForRemovingBook_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The user compares price books on the bag page and the checkout page, they should be equal")]
        public void ThenTheUserComparesPriceBooksOnTheBagPageAndTheCheckoutPageTheyShouldBeEqual()
        {
            ScenarioContext.Current.Pending();
        }
       
        
    }
}
