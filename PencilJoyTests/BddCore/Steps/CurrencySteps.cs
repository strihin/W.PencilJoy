
using System;
using OpenQA.Selenium;
using PencilJoyTests.Pages;
using TechTalk.SpecFlow;

namespace PencilJoyTests.BddCore.Steps
{
    [Binding]
    public class EditingCurrencyAndCheckPriceForABookSteps
    {
        private IWebDriver currentDriver;
        internal PreviewPage previewPage = new PreviewPage();
        internal BagPage bagPage = new BagPage();
        internal MessageAndIdentificationPage messagePage = new MessageAndIdentificationPage();
        internal FooterPage footerPage = new FooterPage();

        [When(@"The user clicks the dropdown with currencies in the footer and chooses currency item as (.*)")]
        [When(@"The user clicks the dropdown with currency and chooses currency item as (.*)")]
        public void WhenTheUserClicksTheDropdownWithCurrencyAndChoosesCurrencyItemAs(string currencyName)
        {
            footerPage.EditCurrency(currencyName);
        }
        
        [When(@"The user clicks the dropdown with currencies and chooses currency item as (.*)")]
         public void WhenTheUserClicksTheDropdownWithCurrenciesAndChoosesCurrencyItemAsUSD(string currencyName)
        {
            bagPage.EditCurrency(currencyName);
        }

        [Then(@"The currency in the field ""(.*)"" on the bag page should be equal ""(.*)""")]
        [Then(@"The currency in the field ""(.*)"" on the bag page is  should be equal ""(.*)""")]
        [Then(@"The currency in the field ""(.*)"" on the bag page is ""(.*)""")]
        public void ThenTheCurrencyInTheFieldOnTheBagPageIsUSD(string fieldName, string expectedCurrency)
        {
            bagPage.IsCorrectCurrency(fieldName, expectedCurrency);
        }

        [Then(@"The active currency in the dropdown with currencies on the bag page should be equal ""(.*)""")]
        public void ThenTheActiveCurrencyInTheDropdownWithCurrenciesOnTheBagPageShouldBeEqualUSD(string currency)
        {
            bagPage.IsActiveCurrency(currency);
        }

        [Then(@"The currency is changed in the button Order for as ""(.*)""")]
        public void ThenTheCurrencyIsChangedInTheButtonOrderForAsUSD(string currency)
        {
            previewPage.IsButtonContainSymbolCurrency(currency);
        }

        [Then(@"The price for a book in the button Order for is edited\.")]
        public void ThenThePriceForABookInTheButtonOrderForIsEdited_()
        {
            previewPage.CheckValuesInTheButton();
        }

        [When(@"The user clicks th button Next for redirecting to the bag page")]
        public void WhenTheUserClicksThButtonNextForRedirectingToTheBagPage()
        {
            messagePage.ComfirmForm();
        }
        
        [Then(@"The active currency in the dropdown with currencies in the footer should be equal USD")]
        public void ThenTheActiveCurrencyInTheDropdownWithCurrenciesInTheFooterShouldBeEqualUSD(string currency)
        {
            footerPage.IsActiveCurrency(currency);
        }
    }
}
