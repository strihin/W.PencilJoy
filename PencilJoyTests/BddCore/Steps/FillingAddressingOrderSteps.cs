using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace PencilJoyTests.BddCore.Steps
{
    [Binding]
    public sealed class FillingAddressingOrderSteps
    {
        [Given(@"The user fills fields for shipping address with correct data as (.*)\t(.*)\t(.*)\t(.*)\t(.*)\t(.*)\t(.*)\t(.*)")]
        public void GivenTheUserFillsFieldsForShippingAddressWithCorrectDataAs(string p0, string p1, string p2, string p3, string p4, string p5, string p6, string p7)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"The user clicks the checkbox ""(.*)""")]
        public void GivenTheUserClicksTheCheckbox(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"The user fills fields for billing address with correct data as (.*)\t(.*)\t(.*)\t(.*)\t(.*)\t(.*)\t(.*)\t(.*)")]
        public void GivenTheUserFillsFieldsForBillingAddressWithCorrectDataAs(string p0, string p1, string p2, string p3, string p4, string p5, string p6, string p7)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"All fields in the Billing ahd Shipping are filled")]
        public void WhenAllFieldsInTheBillingAhdShippingAreFilled()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The values in Blocks should be difference")]
        public void ThenTheValuesInBlocksShouldBeDifference()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"The user fills fields for shipping address with correct data")]
        public void GivenTheUserFillsFieldsForShippingAddressWithCorrectData()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"The user fills fields for billing address with correct data")]
        public void GivenTheUserFillsFieldsForBillingAddressWithCorrectData()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user clicks the field ""(.*)"" in the block ""(.*)"" with USA")]
        public void WhenTheUserClicksTheFieldInTheBlockWithUSA(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The field  ""(.*)"" should be dropdown")]
        public void ThenTheFieldShouldBeDropdown(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user clicks the field ""(.*)"" in the block ""(.*)"" with Austria")]
        public void WhenTheUserClicksTheFieldInTheBlockWithAustria(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The field  ""(.*)"" should be textbox")]
        public void ThenTheFieldShouldBeTextbox(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"The user clicks the checkbox ""(.*)"" in the block ""(.*)""")]
        public void GivenTheUserClicksTheCheckboxInTheBlock(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"The user fills fields for shipping address by incorrect data")]
        public void GivenTheUserFillsFieldsForShippingAddressByIncorrectData()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"clicks the checkbox ""(.*)""")]
        public void GivenClicksTheCheckbox(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Page doesn`t redirected to successful page and shipping`s fields, which haven`t passed, get a red border\.")]
        public void ThenPageDoesnTRedirectedToSuccessfulPageAndShippingSFieldsWhichHavenTPassedGetARedBorder_()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"The user fills fields for billing address by incorrect data")]
        public void GivenTheUserFillsFieldsForBillingAddressByIncorrectData()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Page doesn`t redirected to successful page and billing address` fields, which haven`t passed, get a red border\.")]
        public void ThenPageDoesnTRedirectedToSuccessfulPageAndBillingAddressFieldsWhichHavenTPassedGetARedBorder_()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user clicks the checkbox ""(.*)""")]
        public void WhenTheUserClicksTheCheckbox(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The fields and checkbox in block ""(.*)"" doesn`t available\.")]
        public void ThenTheFieldsAndCheckboxInBlockDoesnTAvailable_(string p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
