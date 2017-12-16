using System;
using NUnit.Framework;
using OpenQA.Selenium;
using PencilJoyTests.Pages;
using TechTalk.SpecFlow;

namespace PencilJoyTests.BddCore.Steps
{
    [Binding]
    public class VerifyDiscountForNextBookSteps
    {
        private IWebDriver currentDriver = null;
        private BagPage bagPage = new BagPage();

        private const string currentPageTitle = Helper.StartPage + "/bag";
        private const string checkoutPageTitle = Helper.StartPage + "/checkout";

        [When(@"The user has (.*) book in the bag")]
        [When(@"The user has (.*) books in the bag")]
        public void WhenTheUserHasBooksInTheBag(int bookCount)
        {
           
        }
        
        [When(@"The user is on the checkout page")]
        public void WhenTheUserIsOnTheCheckoutPage()
        {
            Assert.AreEqual(currentDriver.Url, checkoutPageTitle);
        }
        
        [Then(@"The user has correct discount percent for each book as (.*), (.*)")]
        public void ThenTheUserHasCorrectDiscountPercentForEachBookAs(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The user compares price books on the bag page and the checkout page, they should be equal")]
        public void ThenTheUserComparesPriceBooksOnTheBagPageAndTheCheckoutPageTheyShouldBeEqual()
        {
            ScenarioContext.Current.Pending();
        }
        [Given(@"The user saves price book on the bag page")]
        public void GivenTheUserSavesPriceBookOnTheBagPage()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
