using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace PencilJoyTests.BddCore.Steps
{
    [Binding]
    public sealed class AuthorizationSteps
    {
        [Given(@"The user is a new user")]
        public void GivenTheUserIsANewUser()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"The user is on the message page")]
        public void GivenTheUserIsOnTheMessagePage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"The active tab is ""(.*)""")]
        public void GivenTheActiveTabIs(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user fills correct data for fields  as (.*) , (.*)")]
        public void WhenTheUserFillsCorrectDataForFieldsAs(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The user is redirected to the bag page")]
        public void ThenTheUserIsRedirectedToTheBagPage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user fills data for fields, which exists in DB")]
        public void WhenTheUserFillsDataForFieldsWhichExistsInDB()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The user doesn`t redirected to the bag page")]
        public void ThenTheUserDoesnTRedirectedToTheBagPage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user fills correct name")]
        public void WhenTheUserFillsCorrectName()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user fills invalid email as ""(.*)""")]
        public void WhenTheUserFillsInvalidEmailAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user doesn`t fill data for fields")]
        public void WhenTheUserDoesnTFillDataForFields()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"The user is a registrated user")]
        public void GivenTheUserIsARegistratedUser()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"The user clicks the tab ""(.*)""")]
        public void GivenTheUserClicksTheTab(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user fills data for fields for expired account")]
        public void WhenTheUserFillsDataForFieldsForExpiredAccount()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user fills data for fields, which no exists in DB")]
        public void WhenTheUserFillsDataForFieldsWhichNoExistsInDB()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user fills data for fields, which exists in DB  with incorrect password")]
        public void WhenTheUserFillsDataForFieldsWhichExistsInDBWithIncorrectPassword()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user fills data for fields, which exists in DB  with incorrect email")]
        public void WhenTheUserFillsDataForFieldsWhichExistsInDBWithIncorrectEmail()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
