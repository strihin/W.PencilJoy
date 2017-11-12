using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace PencilJoyTests.BddCore.Steps
{
    [Binding]
    public sealed class FillingCreditCardSteps
    {
        [Given(@"The user is on checkout page")]
        public void GivenTheUserIsOnCheckoutPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"The user correct fills the fields for Billing and Shipping Addresses")]
        public void GivenTheUserCorrectFillsTheFieldsForBillingAndShippingAddresses()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"The user fills the fields for ""(.*)"" tab with correct data  such as (.*)\t(.*) (.*)\t(.*)")]
        public void GivenTheUserFillsTheFieldsForTabWithCorrectDataSuchAs(string p0, string p1, string p2, string p3, string p4)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user clicks the button ""(.*)""")]
        public void WhenTheUserClicksTheButton(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Page is redirected to successful page")]
        public void ThenPageIsRedirectedToSuccessfulPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"The user fills the card number and expiration date for ""(.*)"" tab by correct data")]
        public void GivenTheUserFillsTheCardNumberAndExpirationDateForTabByCorrectData(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"The user fills the card verification value by incorrect data")]
        public void GivenTheUserFillsTheCardVerificationValueByIncorrectData()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user left the fields be empty")]
        public void WhenTheUserLeftTheFieldsBeEmpty()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Page doessn`t redirected to successful page")]
        public void ThenPageDoessnTRedirectedToSuccessfulPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"It should be shown message ""(.*)""")]
        public void ThenItShouldBeShownMessage(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"The user fills the card number and expiration date for the tab ""(.*)"" with correct data")]
        public void GivenTheUserFillsTheCardNumberAndExpirationDateForTheTabWithCorrectData(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user fills the textbox ""(.*)"" with incorrect data")]
        public void WhenTheUserFillsTheTextboxWithIncorrectData(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Page doesn`t redirected to successful page")]
        public void ThenPageDoesnTRedirectedToSuccessfulPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"The user fills the card number and card verification value for the tab ""(.*)"" with correct data")]
        public void GivenTheUserFillsTheCardNumberAndCardVerificationValueForTheTabWithCorrectData(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user fills the expiration date with expired date such as (.*)-January for month and (.*) for year")]
        public void WhenTheUserFillsTheExpirationDateWithExpiredDateSuchAs_JanuaryForMonthAndForYear(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"The user fills the expiration and card verification value date for the tab ""(.*)"" with correct data")]
        public void GivenTheUserFillsTheExpirationAndCardVerificationValueDateForTheTabWithCorrectData(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user fills the card number with incorrect data such as ""(.*)""")]
        public void WhenTheUserFillsTheCardNumberWithIncorrectDataSuchAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
