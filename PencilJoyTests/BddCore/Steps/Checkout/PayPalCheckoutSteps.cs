using System;
using NUnit.Framework;
using OpenQA.Selenium;
using PencilJoyTests.Pages;
using TechTalk.SpecFlow;

namespace PencilJoyTests.BddCore.Steps
{
    [Binding]
    public class PayPalCheckoutSteps
    {
        private IWebDriver currentDriver;
        internal CheckoutBillingAddressPage checkoutBillingAddress = new CheckoutBillingAddressPage();
        internal CheckoutShippingAddressPage checkoutShippingAddress = new CheckoutShippingAddressPage();
        internal CheckoutPaymentPage CheckoutPaymentPage = new CheckoutPaymentPage();

        private const string currentPageTitle = Helper.StartPage + "/checkout";
        private const string nextPageTitle = "https://www.paypal.com/cgi-bin/webscr?cmd=_express-checkout&useraction=commit&token=EC-27J8159741236023F#/checkout/signup";

       
       [When(@"The user clicks the tab PayPal in the Payment Data")]
       [Given(@"The user clicks the tab PayPal in the Payment Data")]
        public void GivenTheUserClicksTheTabInThePaymentData()
        {
            CheckoutPaymentPage.SelectTabPaymentPaypal();
        }

       [When(@"The user clicks the button Check out with PayPal")]
       public void WhenTheUserClicksTheButtonCheckOutWithPayPal()
       {
           CheckoutPaymentPage.ConfirmPaypal();
       }
        
        [Then(@"The tab should show the button Check out with PayPal")]
        public void ThenTheTabShouldShowTheButtonCheckOutWithPayPal()
        {
            CheckoutPaymentPage.IsElementShown();
        }
        
        [Then(@"The page is redirected to PayPal service")]
        public void ThenThePageIsRedirectedToPayPalService()
        {
            Assert.AreEqual(currentDriver.Url, nextPageTitle);
        }
    }
}
