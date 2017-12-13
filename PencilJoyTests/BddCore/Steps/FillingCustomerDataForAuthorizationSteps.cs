using System;
using NUnit.Framework;
using OpenQA.Selenium;
using PencilJoyTests.Data;
using PencilJoyTests.Pages;
using TechTalk.SpecFlow;

namespace PencilJoyTests
{
    [Binding]
    public class FillingCustomerSDataForAuthorizationSteps
    {
        private IWebDriver currentDriver = null;
        private MessageAndIdentificationPage messageAndIdentificationPage = new MessageAndIdentificationPage();
       
        private const string currentPageTitle = Helper.StartPage + "/message";
        private const string nextPageTitle = Helper.StartPage + "/bag";
        
        [Given(@"The user is a new user")]
        public void GivenTheUserIsANewUser() { }
        
        [Given(@"The user is on the message page")]
        public void GivenTheUserIsOnTheMessagePage()
        {
            Assert.AreEqual(currentDriver.Url, currentPageTitle);
        }
        
        [Given(@"The active tab is the New customer")]
        public void GivenTheActiveTabIsTheNewCustomer()
        {
            Assert.IsTrue(messageAndIdentificationPage.CheckActiveTab());
        }
        
        [Given(@"The user is a registrated user")]
        public void GivenTheUserIsARegistratedUser() { }
        
        [Given(@"The user clicks the tab Returning customer")]
        public void GivenTheUserClicksTheTabReturningCustomer()
        {
            messageAndIdentificationPage.ClickTabReturningCustomer();
        }
        
        [When(@"The user fills correct data for fields  as (.*), (.*)")]
        public void WhenTheUserFillsCorrectDataForFieldsAs(string name, string email)
        {
            messageAndIdentificationPage.LoginNewCustomer();
        }
        
        [When(@"The user clicks the button Next")]
        public void WhenTheUserClicksTheButtonNext()
        {
            messageAndIdentificationPage.ComfirmForm();
        }

        [When(@"The user fills data for fields, which exists in DB as (.*), (.*)")]
        public void WhenTheUserFillsDataForFieldsWhichExistsInDBAs(string name, string email)
        {
            messageAndIdentificationPage.LoginNewCustomer();
        }

        [When(@"The user fills correct name and invalid email as (.*), (.*)")]
        public void WhenTheUserFillsCorrectNameAndInvalidEmailAs(string name, string email)
        {
            messageAndIdentificationPage.LoginNewCustomer();
        }
        
        [When(@"The user isn`t fill data for fields")]
        public void WhenTheUserIsnTFillDataForFields() { }


        [When(@"The user fills data for fields for expired account as (.*), (.*)")]
        public void WhenTheUserFillsDataForFieldsForExpiredAccountAs(string name, string email)
        {
            messageAndIdentificationPage.LoginNewCustomer();
        }

        [When(@"The user fills data for fields, which no exists in DB as (.*), (.*)")]
        public void WhenTheUserFillsDataForFieldsWhichNoExistsInDBAs(string email, string password)
        {
            messageAndIdentificationPage.LoginReturningCustomer();
        }

        [When(@"The user fills data for fields, which exists in DB  with incorrect password  as (.*), (.*)")]
        public void WhenTheUserFillsDataForFieldsWhichExistsInDBWithIncorrectPasswordAs(string email, string password)
        {
            messageAndIdentificationPage.LoginReturningCustomer();
        }
        
        [When(@"The user fills data for fields, which exists in DB  with incorrect email  as  (.*), (.*)")]
        public void WhenTheUserFillsDataForFieldsWhichExistsInDBWithIncorrectEmailAs(string email, string password)
        {
            messageAndIdentificationPage.LoginReturningCustomer();
        }
        
        [Then(@"The user is redirected to the bag page")]
        public void ThenTheUserIsRedirectedToTheBagPage()
        {
            Assert.AreEqual(currentDriver.Url, nextPageTitle);
        }
        
        [Then(@"The user isn`t redirected to the bag page")]
        public void ThenTheUserIsnTRedirectedToTheBagPage()
        {
            Assert.AreEqual(currentDriver.Url, currentPageTitle);
        }
      
    }
}
