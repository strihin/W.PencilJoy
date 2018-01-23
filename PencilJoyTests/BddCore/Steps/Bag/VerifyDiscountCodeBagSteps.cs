using System;
using NUnit.Framework;
using OpenQA.Selenium;
using PencilJoyTests.Pages;
using TechTalk.SpecFlow;

namespace PencilJoyTests.BddCore.Steps
{
    [Binding]
    public class VerifyDiscountCodeBagSteps
    {
        private IWebDriver currentDriver = null;
        private BagPage bagPage = new BagPage();

        private const string currentPageTitle = Helper.StartPage + "/bag";
        private const string editPageTitle = Helper.StartPage + "/edit";
        private const string checkoutPageTitle = Helper.StartPage + "/checkout";

        [Given(@"The user fills  field for discount code with correct data  as (.*)")]
        public void GivenTheUserFillsFieldForDiscountCodeWithCorrectDataAsKendra(string DiscountCode)
        {
            bagPage.EnterDiscountCode(DiscountCode);
        }

        [When(@"The user clicks the button Check")]
        [Given(@"The user clicks the button Check")]
        public void GivenTheUserClicksTheButtonCheck()
        {
            bagPage.ConfirmDiscountCode();
        }

        [When(@"The user fills field for discount code with expired end date as (.*)")]
        [When(@"The user fills field for discount code with expired start date as (.*)")]
        [When(@"The user fills the field for discount code with correct data as (.*)")]
        [When(@"The user fills  field for discount code with incorrect data as (.*)")]
        [Given(@"The user fills  field for discount code with incorrect data  as (.*)")]
        public void GivenTheUserFillsFieldForDiscountCodeWithIncorrectDataAs(string DiscountCode)
        {
            bagPage.EnterDiscountCode(DiscountCode);
        }
        
        [When(@"The user fills field for discount code with correct data as (.*)")]
        public void WhenTheUserFillsFieldForDiscountCodeWithCorrectDataAsKendra(string DiscountCode)
        {
            bagPage.EnterDiscountCode(DiscountCode);
        }
        
        [When(@"The user clicks the button Next for redirecting to the checkout page")]
        public void WhenTheUserClicksTheButtonNextForRedirectingToTheCheckoutPage()
        {
            bagPage.ConfirmForm();
        }
      
        [Then(@"The user gets discount for his order as (.*)")]
        public void ThenTheUserGetsDiscountForHisOrderAs(int p0)
        {
            
        }
        
        [Then(@"The user is redirected to the checkout page,")]
        public void ThenTheUserIsRedirectedToTheCheckoutPage()
        {
            Assert.AreEqual(currentDriver.Url, checkoutPageTitle);
        }
        
        [Then(@"The field for discount code should get value as (.*)")]
        public void ThenTheFieldForDiscountCodeShouldGetValueAs(int expectedPercent)
        {
            Assert.IsTrue(bagPage.IsCodeValid(expectedPercent));
        }
        [Then(@"The user doesn`t redirected to the checkout page")]
        public void ThenTheUserDoesnTRedirectedToTheCheckoutPage()
        {
            Assert.IsTrue(bagPage.IsCodeUnchecked());
        }

        [Then(@"The field for discount code should get a red border")]
        [Then(@"The user doesn`t get discount for his order, field for discount code should get a red border\.")]
        public void ThenTheUserDoesnTGetDiscountForHisOrderFieldForDiscountCodeShouldGetARedBorder_()
        {
            Assert.IsTrue(bagPage.IsCodeUnchecked());
        }
        
        [Then(@"The user doesn`t redirected to the checkout page, field for discount code should get a red border\.")]
        public void ThenTheUserDoesnTRedirectedToTheCheckoutPageFieldForDiscountCodeShouldGetARedBorder_()
        {
            Assert.AreNotEqual(currentDriver.Url, checkoutPageTitle);
        }
        
        [Then(@"The user gets right discount percent for his order as (.*)")]
        public void ThenTheUserGetsRightDiscountPercentForHisOrderAs(int expectedPercent)
        {
            Assert.IsTrue(bagPage.IsCodeValid(expectedPercent));
        }

    }
}
