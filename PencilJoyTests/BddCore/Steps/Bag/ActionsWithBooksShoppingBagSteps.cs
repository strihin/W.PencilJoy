using System;
using NUnit.Framework;
using OpenQA.Selenium;
using PencilJoyTests.Pages;
using TechTalk.SpecFlow;

namespace PencilJoyTests.BddCore.Steps
{
    [Binding]
    public class ActionsWithBooksShoppingBagSteps
    {
        private AuthorizationSteps authorizationSteps = new AuthorizationSteps();
        private IWebDriver currentDriver = null;
        private BagPage bagPage = new BagPage();

        private const string currentPageTitle = Helper.StartPage + "/bag";
        private const string editPageTitle = Helper.StartPage + "/edit";
        private const string checkoutPageTitle = Helper.StartPage + "/checkout";

        public void GoToCheckoutPage()
        {
            GivenTheUserIsANewCustomer();
        }
        [Given(@"The user is a new customer")]
        public void GivenTheUserIsANewCustomer()
        {
            authorizationSteps.GoToBagPageAsNewUser();
            bagPage.ContinueShopping();
        }

        [Given(@"The user is a returning customer")]
        public void GivenTheUserIsAReturningCustomer()
        {
            authorizationSteps.GoToBagPageAsRegistratedUser();
        }
        
        [Given(@"The basket contains any items")]
        public void GivenTheBasketContainsAnyItems()
        {
            bagPage.CheckBasketAsEmpty();
        }

        [Given(@"The user clicks the button X at the book with number (.*)")]
        public void GivenTheUserClicksTheButtonXAtTheBook(int number)
        {
            bagPage.RemoveBook(number);
        }

        [Given(@"The user removes all books in the order")]
        public void TheUserRemovesAllBooksInTheOrder()
        {
            bagPage.RemoveAllBooks(currentDriver);
        }
        
       [Given(@"The user gets empty cart with the button Continue shopping")]
        public void GivenTheUserGetsEmptyCartWithTheButtonContinueShopping()
       {
           bagPage.CheckTheButtonIsVisible();
       }
        
        [When(@"The user clicks the button Shop more books")]
        public void WhenTheUserClicksTheButtonShopMoreBooks()
        {
            bagPage.ShopMoreBooks();
        }
      
       [When(@"The user hasn`t add any product in bag")]
        public void WhenTheUserHasnTAddAnyProductInBag() { }
        
        [When(@"The user clicks the button Continue shopping")]
        public void WhenTheUserClicksTheButtonContinueShopping()
        {
            bagPage.ContinueShopping();
        }
        
        [When(@"The user clicks the link Edit for a book with number (.*)")]
        public void WhenTheUserClicksTheLinkEditForABookWithNumber(int number)
        {
            bagPage.EditBook(number);
        }
        
        [Then(@"The user is redirected on the create book page for adding a new book")]
        public void ThenTheUserIsRedirectedOnTheCreateBookPageForAddingANewBook()
        {
            Assert.AreEqual(currentPageTitle, Helper.StartPage);
        }

        [Then(@"The basket does not contain the removing item")]
        public void ThenTheBasketDoesNotContainTheRemovingItem()
        {
            Assert.IsTrue(bagPage.VerifyCountBooks());
        }
        
        [Then(@"The popup notification for removing is shown")]
        public void ThenThePopupNotificationForRemovingIsShown()
        {
            Assert.IsTrue(bagPage.IsAlertExists(currentDriver));
        }
       
        [Then(@"The user gets empty cart with the button Continue shopping")]
        public void ThenTheUserGetsEmptyCartWithTheButtonContinueShopping()
        {
            bagPage.CheckTheButtonIsVisible();
        }
        
        [Then(@"The basket has no contents")]
        public void ThenTheBasketHasNoContents()
        {
            bagPage.IsBasketEmpty();
        }
        
        [Then(@"The user is redirected to create book page")]
        public void ThenTheUserIsRedirectedToCreateBookPage()
        {
            Assert.AreEqual(currentDriver.Url, Helper.StartPage); 
        }
        
        [Then(@"The user is redirected on the edit book page")]
        public void ThenTheUserIsRedirectedOnTheEditBookPage()
        {
            Assert.AreEqual(currentDriver.Url, editPageTitle); 
        }
        [When(@"The user clicks to the button Next")]
        public void WhenTheUserClicksToTheButtonNext()
        {
            bagPage.ConfirmForm();
        }

        [Then(@"The user is redirected to the checkout page\.")]
        public void ThenTheUserIsRedirectedToTheCheckoutPage_()
        {
            Assert.AreEqual(currentDriver.Url, checkoutPageTitle); 
        }
    }
}
