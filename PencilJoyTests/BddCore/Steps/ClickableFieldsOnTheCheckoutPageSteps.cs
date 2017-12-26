using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using PencilJoyTests.Pages;
using TechTalk.SpecFlow;

namespace PencilJoyTests.BddCore.Steps
{
    [Binding]
    public class ClickableFieldsOnTheCheckoutPageSteps
    {
        private CheckoutShippingAddressPage checkoutShippingAddress = new CheckoutShippingAddressPage();

        [Then(@"The fields and checkbox in the block ""(.*)"" are disabled\.")]
        public bool ThenTheFieldsAndCheckboxInTheBlockAreDisabled_(string blockName)
        {
            Assert.IsTrue(checkoutShippingAddress.AreElementsDisabled(blockName));
        }
    }
}
