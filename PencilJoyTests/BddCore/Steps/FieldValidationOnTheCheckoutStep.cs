using System;
using NUnit.Framework;
using OpenQA.Selenium;
using PencilJoyTests.Pages;
using TechTalk.SpecFlow;

namespace PencilJoyTests.BddCore.Steps
{
    [Binding]
    public class OrderAddressingValidationSteps
    {
        private IWebDriver currentDriver;
        internal CheckoutBillingAddressPage checkoutBillingAddress = new CheckoutBillingAddressPage();
        internal CheckoutShippingAddressPage checkoutShippingAddress = new CheckoutShippingAddressPage();
        internal CheckoutPaymentPage CheckoutPaymentPage = new CheckoutPaymentPage();

        private const string currentPageTitle = Helper.StartPage + "/checkout";
        private const string nextPageTitle = Helper.StartPage + "/success";
      
        [When(@"The user does not specify any billing address information")]
        [When(@"The user does not specify any shipping address information")]
        public void WhenTheUserDoesNotSpecifyAnyShippingAddressInformation() { }
        
        [When(@"The user specifies  in shipping address all fields becides fields Phone as (.*) (.*) (.*) (.*) (.*) (.*) (.*) (.*)")]
        [When(@"The user specifies  in shipping address all fields with correct data and field Phone as string  as (.*) (.*) (.*) (.*)\t(.*) (.*) (.*) (.*)")]
        [When(@"The user specifies  in shipping address all fields becides fields First name and Last name as (.*) (.*) (.*) (.*) (.*) (.*) (.*) (.*)")]
        public void WhenTheUserSpecifiesInShippingAddressAllFieldsBecidesFieldsFirstNameAndLastNameAs(string Username, string Lastname, string Street, string City, string ZipCode, string Phone, int NumberCountry, string Region)
        {
            checkoutShippingAddress.LoginIntoShippingAddress(Username, Lastname, Street, City, ZipCode, Phone, NumberCountry, Region);
        }

        [When(@"The user specifies  in billing address all fields becides fields City and Postcode / zip code  as (.*) (.*) (.*) (.*) (.*) (.*) (.*) (.*)")]
        [When(@"The user specifies  in billing address all fields with correct data and field Phone as string as (.*) (.*) (.*) (.*) (.*) (.*) (.*) (.*)")]
        [When(@"The user specifies  in billing address all fields becides fields First name and Last name as (.*) (.*) (.*) (.*) (.*) (.*) (.*) (.*)")]
        public void WhenTheUserSpecifiesInBillingAddressAllFieldsBecidesFieldsFirstNameAndLastNameAs(string Username, string Lastname, string Street, string City, string ZipCode, string Phone, int NumberCountry, string Region)
        {
            checkoutBillingAddress.LoginIntoBillingAddress(Username, Lastname, Street, City, ZipCode, Phone, NumberCountry, Region);
        }
        
        [Then(@"The user should be notified that all fields in the block ""(.*)"" are required")]
        public void ThenTheUserShouldBeNotifiedThatAllFieldsInTheBlockAreRequired(string blockName)
        {
            Assert.IsTrue(checkoutShippingAddress.AreElementsRequired(blockName));
        }
        [Then(@"The user should be notified that the field ""(.*)"" in the block ""(.*)"" doesn`t correct")]
        [Then(@"The user should be notified that the ""(.*)"" in the block ""(.*)"" is required")]
        public void ThenTheUserShouldBeNotifiedThatTheInTheBlockIsRequired(string fieldName, string blockName)
        {
            Assert.IsTrue(checkoutShippingAddress.IsElementRequired(blockName, fieldName));
        }

        [When(@"The user tries to complete the addressing step")]
        public void WhenTheUserTriesToCompleteTheAddressingStep()
        {
            CheckoutPaymentPage.ConfirmForm();
        }
    }
}