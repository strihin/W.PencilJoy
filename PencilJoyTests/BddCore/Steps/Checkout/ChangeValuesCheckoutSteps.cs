using OpenQA.Selenium;
using PencilJoyTests.Pages;
using TechTalk.SpecFlow;

namespace PencilJoyTests.BddCore.Steps
{
    [Binding]
    public class ChangeValuesCheckoutSteps
    {
        
        internal CheckoutBillingAddressPage checkoutBillingAddress = new CheckoutBillingAddressPage();
        internal CheckoutShippingAddressPage checkoutShippingAddress = new CheckoutShippingAddressPage();
        internal CheckoutPaymentPage CheckoutPaymentPage = new CheckoutPaymentPage();


       [Given(@"The user fills fields for shipping address with data  as (.*) (.*) (.*) (.*) (.*) (.*) (.*) (.*)")]
        public void GivenTheUserFillsFieldsForShippingAddressWithDataAs(string Username, string Lastname, string Street, string City, string ZipCode, string Phone, int NumberCountry, string Region)
        {
            checkoutBillingAddress.LoginIntoBillingAddress(Username, Lastname, Street, City, ZipCode, Phone, NumberCountry, Region);
        }
        
        [Given(@"The user clicks the checkbox Billing to this address in the block Shipping Address")]
        public void GivenTheUserClicksTheCheckboxBillingToThisAddressInTheBlockShippingAddress()
        {
            checkoutShippingAddress.BillToThisAddress();
        }

          [When(@"The user edits the field ""(.*)"" in the block Shipping Address ""(.*)""")]
        public void WhenTheUserEditsTheFieldInTheBlockShippingAddress(string fieldName, string fieldValue)
        {
            checkoutShippingAddress.EditField(fieldName, fieldValue);
        }

        [Then(@"The field ""(.*)"" should be edited")]
        public void ThenTheFieldShouldBeEdited(string fieldName)
        {
            checkoutShippingAddress.CompareValuesInTheField(fieldName);
        }

       
        [When(@"The user edits the field ""(.*)"" in the block Billing Address as ""(.*)""")]
        public void WhenTheUserEditsTheFieldInTheBlockBillingAddressAs(string fieldName, string fieldValue)
        {
            checkoutBillingAddress.EditField(fieldName, fieldValue);
        }
    }
}
