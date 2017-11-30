using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using PencilJoyTests.Pages;
using TechTalk.SpecFlow;

namespace PencilJoyTests.BddCore.steps
{
    [Binding]
    public sealed class FillingChildDataSteps
    {
        private IWebDriver currentDriver = null;
        CreateBookPage createBookPage = new CreateBookPage();

        [Given(@"The user is a customer")]
        public void GivenTheUserIsACustomer()
        {
            Assert.AreEqual(currentDriver.Title, "Personalized Books and Gifts from Pencil Joy");
        }

        [Given(@"The user is on the create book page")]
        public void GivenTheUserIsOnTheCreateBookPage()
        {
            Assert.AreEqual(currentDriver.Title, "Personalized Books and Gifts from Pencil Joy");
        }

        [When(@"The user fills correct data to fields as (.*) , (.*) , (.*) (.*) , (.*)")]
        public void WhenTheUserFillsCorrectDataToFieldsAs(string p0, string p1, string p2, string p3, string p4)
        {
            createBookPage.EntryLoginIntoBookData();
           
        }

        [Then(@"The user is redirected to the preview page")]
        public void ThenTheUserIsRedirectedToThePreviewPage()
        {
            ScenarioContext.Current.Pending();  
        }

        [When(@"The user fills correct data to all fields besides fields for birthday as month and day")]
        public void WhenTheUserFillsCorrectDataToAllFieldsBesidesFieldsForBirthdayAsMonthAndDay()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user fills incorrect data to fields")]
        public void WhenTheUserFillsIncorrectDataToFields()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The user doesn`t redirected to the preview page")]
        public void ThenTheUserDoesnTRedirectedToThePreviewPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The fields with incorrect data gets a red border\.")]
        public void ThenTheFieldsWithIncorrectDataGetsARedBorder_()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user fills correct data to fields besides the field ""(.*)""")]
        public void WhenTheUserFillsCorrectDataToFieldsBesidesTheField(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user leaves the field ""(.*)"" empty")]
        public void WhenTheUserLeavesTheFieldEmpty(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The field ""(.*)"" gets a red border\.")]
        public void ThenTheFieldGetsARedBorder_(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user fills correct data to fields without choosing the button ""(.*)"" as ""(.*)""")]
        public void WhenTheUserFillsCorrectDataToFieldsWithoutChoosingTheButtonAs(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The buttons ""(.*)"", ""(.*)"" get a red border\.")]
        public void ThenTheButtonsGetARedBorder_(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user fills correct data to fields without choosing the option ""(.*)""")]
        public void WhenTheUserFillsCorrectDataToFieldsWithoutChoosingTheOption(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
