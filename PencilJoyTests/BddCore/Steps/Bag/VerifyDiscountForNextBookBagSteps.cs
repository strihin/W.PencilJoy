using NUnit.Framework;
using OpenQA.Selenium;
using PencilJoyTests.Pages;
using TechTalk.SpecFlow;

namespace PencilJoyTests.BddCore.Steps
{
    [Binding]
    public class VerifyDiscountForNextBookBagSteps
    {
        
        private BagPage bagPage = new BagPage();
        internal ActionsWithBooksShoppingBagSteps bagSteps = new ActionsWithBooksShoppingBagSteps();
        internal AuthorizationSteps authorizationSteps = new AuthorizationSteps();

        private const string currentPageTitle = Helper.StartPage + "/bag";
        private const string checkoutPageTitle = Helper.StartPage + "/checkout";

        [When(@"The user has (.*) book in the bag")]
        [When(@"The user has (.*) books in the bag")]
        public void WhenTheUserHasBooksInTheBag(int bookCount)
        {
           authorizationSteps.GoToBagPageAsRegistratedUser();
           Assert.IsTrue(bagPage.VerifyBooksAmount(bookCount));
        }
        
        [When(@"The user is on the checkout page")]
        public void WhenTheUserIsOnTheCheckoutPage()
        {
            bagSteps.GoToCheckoutPage();
            Assert.AreEqual(Hooks.WebDriver.Url, checkoutPageTitle);
        }
        
        [Then(@"The user has correct discount percent for each book as (.*), (.*)")]
        public void ThenTheUserHasCorrectDiscountPercentForEachBookAs(int numberBook, int percentBook)
        {
            Assert.IsTrue(bagPage.VerifyGeneralDiscountCodes(numberBook, percentBook));
        }
     
    }
}
