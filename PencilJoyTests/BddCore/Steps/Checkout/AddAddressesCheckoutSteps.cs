using NUnit.Framework;
using OpenQA.Selenium;
using PencilJoyTests.Data;
using PencilJoyTests.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace PencilJoyTests.BddCore.Steps
{
    [Binding]
    public class AddAddressesCheckoutSteps
    {
        private  IWebDriver currentDriver;
        internal CheckoutBillingAddressPage checkoutBillingAddress = new CheckoutBillingAddressPage();
        internal CheckoutShippingAddressPage checkoutShippingAddress = new CheckoutShippingAddressPage();
        internal CheckoutPaymentPage CheckoutPaymentPage = new CheckoutPaymentPage();
        internal ActionsWithBooksShoppingBagSteps BagSteps = new ActionsWithBooksShoppingBagSteps();

        private const string currentPageTitle = Helper.StartPage + "/checkout";
        private const string nextPageTitle = Helper.StartPage + "/success";

        [Given(@"The user is on the checkout page")]
        [Given(@"The user is on checkout page")]
        public void GivenTheUserIsOnCheckoutPage()
        {
            BagSteps.GoToCheckoutPage();
            Assert.AreEqual(currentDriver.Url, currentPageTitle); 
        }

        [When(@"The user fills fields for shipping address with correct data:")]
        public void GivenTheUserFillsFieldsForShippingAddressWithCorrectData(Table table)
        {
            var convertingTable = table.CreateInstance<CheckoutAddressData>();
            checkoutBillingAddress.LoginIntoBillingAddress(convertingTable.Username, convertingTable.Lastname,
                convertingTable.Street, convertingTable.City, convertingTable.ZipCode, convertingTable.Phone, convertingTable.NumberCountry, convertingTable.Region
                );
        }
      
        [Given(@"The user clicks the checkbox Billing to this address in the block Shipping address")]
        [Given(@"The user clicks the checkbox Bill to this address")]
        public void GivenTheUserClicksTheCheckboxBillToThisAddress()
        {
             checkoutShippingAddress.BillToThisAddress();
        }
        
        [Given(@"The user fills fields for billing address with correct data:")]
        public void GivenTheUserFillsFieldsForBillingAddressWithCorrectData(Table table)
        {
            var convertingTable = table.CreateInstance<CheckoutAddressData>();
            checkoutBillingAddress.LoginIntoBillingAddress(convertingTable.Username, convertingTable.Lastname,
                convertingTable.Street, convertingTable.City, convertingTable.ZipCode, convertingTable.Phone, convertingTable.NumberCountry, convertingTable.Region
                );
        }

        [Given(@"The user fills fields for shipping address with correct data as (.*) (.*) (.*) (.*) (.*) (.*) (.*) (.*)")]
        [Given(@"The user fills fields for shipping address with incorrect data as  (.*) (.*) (.*) (.*) (.*) (.*) (.*) (.*)")]
        [Given(@"The user fills fields for shipping address with correct data as")]
        public void GivenTheUserFillsFieldsForShippingAddressWithCorrectDataAs(string Username, string Lastname, string Street, string City, string ZipCode, string Phone, int NumberCountry, string Region)
        {
            checkoutBillingAddress.LoginIntoBillingAddress(Username, Lastname, Street, City, ZipCode, Phone, NumberCountry, Region);
        }

        [Given(@"The user fills fields for billing address with incorrect data  as (.*) (.*) (.*) (.*)\t(.*) (.*) (.*) (.*)")]
        [Given(@"The user fills fields for billing address with correct data as (.*) (.*) (.*) (.*)\t(.*) (.*) (.*) (.*)")]
        public void GivenTheUserFillsFieldsForBillingAddressWithCorrectDataAs(string Username, string Lastname, string Street, string City, string ZipCode, string Phone, int NumberCountry, string Region)
        {
            checkoutShippingAddress.LoginIntoShippingAddress(Username, Lastname, Street, City, ZipCode, Phone, NumberCountry, Region);
        }
        
        [Given(@"The user clicks the checkbox Ship to this address")]
        public void GivenTheUserClicksTheCheckboxShipToThisAddress()
        {
            checkoutBillingAddress.ShipToThisAddress();
        }
        
        [When(@"All fields in the Billing ahd Shipping are filled")]
        public void WhenAllFieldsInTheBillingAhdShippingAreFilled()
        {
            Assert.IsFalse(checkoutBillingAddress.AreEmptyFields() && checkoutShippingAddress.AreEmptyFields());
        }
        
        [When(@"The user clicks the button Place your order")]
        public void WhenTheUserClicksTheButtonPlaceYourOrder()
        {
            CheckoutPaymentPage.ConfirmForm();
        }
        
        [When(@"The user clicks the field Country in the block Shipping address with (.*)")]
        public void WhenTheUserClicksTheFieldCountryInTheBlockShippingAddressWith(string CountryName)
        {
            checkoutShippingAddress.SelectCountryField(CountryName);
        }

        [When(@"The user clicks the field Country in the block Billing address with (.*)")]
        public void WhenTheUserClicksTheFieldCountryInTheBlockBillingAddressWith(string CountryName)
        {
            checkoutBillingAddress.SelectCountryField(CountryName);
        }
        
        [When(@"The user clicks the checkbox Ship to this address")]
        public void WhenTheUserClicksTheCheckboxShipToThisAddress()
        {
            checkoutBillingAddress.ShipToThisAddress();
        }
        
        [Then(@"The page is redirected to successful page")]
        public void ThenThePageIsRedirectedToSuccessfulPage()
        {
            Assert.AreEqual(currentDriver.Url, nextPageTitle);
        }
        
      
        [Then(@"The field  State/Region should be dropdown")]
        public void ThenTheFieldStateRegionShouldBeDropdown()
        {
            Assert.IsTrue(checkoutShippingAddress.DoesDropdownExist());
        }
        
        [Then(@"The field  State/Region should be textbox")]
        public void ThenTheFieldStateRegionShouldBeTextbox()
        {
            Assert.IsTrue(checkoutShippingAddress.DoesTextboxExist());
        }

        [Then(@"The page doesn`t redirected to the successful page.")]
        public void ThenThePageDoesnTRedirectedToTheSuccessfulPage()
        {
            Assert.AreNotEqual(currentDriver.Url, nextPageTitle);
        }

        [Then(@"The shipping`s fields, which haven`t passed, get a red border\.")]
        public void ThenTheShippingSFieldsWhichHavenTPassedGetARedBorder_()
        {
            Assert.IsTrue(checkoutShippingAddress.AreFieldsCorrect());
        }

        [Then(@"The billing address` fields, which haven`t passed, get a red border\.")]
        public void ThenTheBillingAddressFieldsWhichHavenTPassedGetARedBorder_()
        {
            Assert.IsTrue(checkoutBillingAddress.AreFieldsCorrect());
        }

        [Then(@"The fields and checkbox in block Shipping address doesn`t available\.")]
        public void ThenTheFieldsAndCheckboxInBlockShippingAddressDoesnTAvailable_()
        {
            Assert.IsTrue(checkoutShippingAddress.AreFieldsDisabled());
        }
        
        [When(@"The user clicks the checkbox Bill to this address")]
        public void WhenTheUserClicksTheCheckboxBillToThisAddress()
        {
            checkoutShippingAddress.BillToThisAddress();
        }

        [Then(@"The fields and checkbox in block Billing address doesn`t available\.")]
        public void ThenTheFieldsAndCheckboxInBlockBillingAddressDoesnTAvailable_()
        {
            Assert.IsTrue(checkoutBillingAddress.AreFieldsDisabled());
        }
        
    }
}
