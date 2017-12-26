using System;
using NUnit.Framework;
using PencilJoyTests.Pages;
using TechTalk.SpecFlow;

namespace PencilJoyTests.BddCore.Steps
{
    [Binding]
    public class RemoveValueFromAddressesFieldsSteps
    {
        private CheckoutShippingAddressPage checkoutShippingAddress = new CheckoutShippingAddressPage();

        [When(@"The user removes  values for the field ""(.*)"" in the block ""(.*)""")]
        public void WhenTheUserRemovesValuesForTheFieldInTheBlock(string fieldName, string blockName)
        {
            checkoutShippingAddress.RemoveField(checkoutShippingAddress.findoutElement(fieldName, blockName));
        }
        
        [Then(@"The field ""(.*)"" should be empty  in the block ""(.*)""")]
        public void ThenTheFieldShouldBeEmptyInTheBlock(string fieldName, string blockName)
        {
            Assert.IsTrue(checkoutShippingAddress.IsFieldEmpty(checkoutShippingAddress.findoutElement(fieldName, blockName)));
        }
    }
}
