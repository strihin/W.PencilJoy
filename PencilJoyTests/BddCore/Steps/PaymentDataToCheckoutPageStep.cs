using System;
using TechTalk.SpecFlow;

namespace PencilJoyTests.BddCore.Steps
{
    [Binding]
    public class AddPaymentDataToCheckoutPageSteps
    {
        [Given(@"The user correct fills the fields for ""(.*)"" as (.*) (.*) (.*) (.*) (.*) (.*) (.*) (.*)")]
        public void GivenTheUserCorrectFillsTheFieldsForAs(string p0, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"The user correct fills the fields for ""(.*)"" as (.*) (.*) (.*) (.*)\t(.*) (.*) (.*) (.*)")]
        public void GivenTheUserCorrectFillsTheFieldsForAs(string p0, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"The user fills the fields for ""(.*)"" tab with correct data  such as (.*) (.*)")]
        public void GivenTheUserFillsTheFieldsForTabWithCorrectDataSuchAs(string p0, string p1, string p2)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"The user chooses the tab ""(.*)""")]
        public void GivenTheUserChoosesTheTab(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"The user left all fields as empty")]
        public void WhenTheUserLeftAllFieldsAsEmpty()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"The user fills the fields for Credit Card tab with correct data and the card verification value with incorrect data as (.*) (.*)")]
        public void WhenTheUserFillsTheFieldsForCreditCardTabWithCorrectDataAndTheCardVerificationValueWithIncorrectDataAs(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"The user fills the fields for Credit Card tab with correct data besides the ""(.*)"" as (.*) (.*)")]
        public void WhenTheUserFillsTheFieldsForCreditCardTabWithCorrectDataBesidesTheAs(string p0, string p1, string p2)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"The user fills the fields for ""(.*)"" tab with correct data besides the ""(.*)"" as (.*) (.*)")]
        public void WhenTheUserFillsTheFieldsForTabWithCorrectDataBesidesTheAs(string p0, string p1, string p2, string p3)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"The user fills the card number with incorrect data such as ""(.*)""")]
        public void WhenTheUserFillsTheCardNumberWithIncorrectDataSuchAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The page is redirected to the successful page")]
        public void ThenThePageIsRedirectedToTheSuccessfulPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The page doessn`t redirected to the successful page")]
        public void ThenThePageDoessnTRedirectedToTheSuccessfulPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"It should be shown the message Could not find payment information\.")]
        public void ThenItShouldBeShownTheMessageCouldNotFindPaymentInformation_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The page doesn`t redirected to the successful page")]
        public void ThenThePageDoesnTRedirectedToTheSuccessfulPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
