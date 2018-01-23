using NUnit.Framework;
using PencilJoyTests.Pages;
using TechTalk.SpecFlow;

namespace PencilJoyTests.BddCore.Steps
{
    [Binding]
    public class ClickableFieldsCheckoutSteps
    {
        private CheckoutShippingAddressPage checkoutShippingAddress = new CheckoutShippingAddressPage();

        [Then(@"The fields and checkbox in the block ""(.*)"" are disabled\.")]
        public bool ThenTheFieldsAndCheckboxInTheBlockAreDisabled_(string blockName)
        {
            Assert.IsTrue(checkoutShippingAddress.AreElementsDisabled(blockName));
        }
    }
}
