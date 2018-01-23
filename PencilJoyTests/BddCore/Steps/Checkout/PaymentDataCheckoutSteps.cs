using System;
using NUnit.Framework;
using OpenQA.Selenium;
using PencilJoyTests.Pages;
using TechTalk.SpecFlow;

namespace PencilJoyTests.BddCore.Steps
{
    [Binding]
    public class PaymentDataCheckoutSteps
    {
        private IWebDriver currentDriver;
        internal CheckoutBillingAddressPage checkoutBillingAddress = new CheckoutBillingAddressPage();
        internal CheckoutShippingAddressPage checkoutShippingAddress = new CheckoutShippingAddressPage();
        internal CheckoutPaymentPage CheckoutPaymentPage = new CheckoutPaymentPage();

        private const string currentPageTitle = Helper.StartPage + "/checkout";
        private const string nextPageTitle = Helper.StartPage + "/success";
      

        [Given(@"The user chooses the tab Credit Card")]
        public void GivenTheUserChoosesTheTabCreditCard()
        {
            CheckoutPaymentPage.SelectTabPaymentPaypal();
        }
        
        [When(@"The user left all fields as empty")]
        public void WhenTheUserLeftAllFieldsAsEmpty() { }

        [When(@"The user fills the fields for Credit Card tab with correct data besides the Expiration date as (.*) (.*) (.*) (.*)")]
        [When(@"The user fills the fields for Credit Card tab with correct data and the card verification value with incorrect data as (.*) (.*) (.*) (.*)")]
        public void WhenTheUserFillsTheFieldsForCreditCardTabWithCorrectDataAndTheCardVerificationValueWithIncorrectDataAs(string creditCard, string cardVerification, int Month, int Year)
        {
            CheckoutPaymentPage.FillPaymentData(creditCard, cardVerification, Month, Year);
        }
      
        [Then(@"The page is redirected to the successful page")]
        public void ThenThePageIsRedirectedToTheSuccessfulPage()
        {
            Assert.AreEqual(currentDriver.Url, nextPageTitle);
        }

        [Then(@"The page doesn`t redirected to the successful page")]
        [Then(@"The page doessn`t redirected to the successful page")]
        public void ThenThePageDoessnTRedirectedToTheSuccessfulPage()
        {
            Assert.AreNotEqual(currentDriver.Url, nextPageTitle);
        }
        
        [Then(@"It should be shown the message (.*)")]
        public void ThenItShouldBeShownTheMessage(string errorMessage)
        {
            Assert.IsTrue(CheckoutPaymentPage.IsErrorDisplayed(errorMessage));
        }
       
        [Given(@"The user correct fills the fields for Billing Address as (.*) (.*) (.*) (.*) (.*) (.*) (.*) (.*)")]
        public void GivenTheUserCorrectFillsTheFieldsForBillingAddressAs(string Username, string Lastname, string Street, string City, string ZipCode, string Phone, int NumberCountry, string Region)
        {
            checkoutBillingAddress.LoginIntoBillingAddress(Username, Lastname, Street, City, ZipCode, Phone, NumberCountry, Region);
        }

        [Given(@"The user correct fills the fields for Shipping Address as (.*) (.*) (.*) (.*) (.*) (.*) (.*) (.*)")]
        [Given(@"The user correct fills the fields for Shipping Address as (.*) (.*) (.*) (.*)\t(.*) (.*) (.*) (.*)")]
        public void GivenTheUserCorrectFillsTheFieldsForShippingAddressAs(string Username, string Lastname, string Street, string City, string ZipCode, string Phone, int NumberCountry, string Region)
        {
            checkoutShippingAddress.LoginIntoShippingAddress(Username, Lastname, Street, City, ZipCode, Phone, NumberCountry, Region);
        }
    }

}
