using NUnit.Framework;
using OpenQA.Selenium;
using PencilJoyTests.Data;
using PencilJoyTests.Pages;
using TechTalk.SpecFlow;

namespace PencilJoyTests.BddCore.steps
{
    [Binding]
    public sealed class FillChildDataSteps
    {
        CreateBookPage createBookPage = new CreateBookPage();
        private CreateBookData createBookData;
        private PreviewPage previewPage = new PreviewPage();
        private const string nextPageTitle = Helper.StartPage + "/preview";

        public void GoNextStep(string username, int numberMonth, int numberDay, int numberSex, int numberCharacter)
        {
            Hooks.WebDriver.Navigate().GoToUrl(Helper.StartPage);
            WhenTheUserFillsCorrectDataToFieldsAs(username, numberMonth, numberDay, numberSex, numberCharacter);
            previewPage.ConfirmGeneralForm();
        }
        public void GoNextStep()
        {
            Hooks.WebDriver.Navigate().GoToUrl(Helper.StartPage);

            // ToDo: read  createBookData from test data source
            createBookData = new CreateBookData("asd", 12, 12, 1, 1);

            WhenTheUserFillsCorrectDataToFieldsAs(createBookData.Username, createBookData.NumberMonth, createBookData.NumberDay, createBookData.NumberSex, createBookData.NumberCharacter);
            previewPage.ConfirmGeneralForm();
        }
        public void GoToEditBookPage()
        {
            GoNextStep();
            previewPage.EditBook();
        }
        public void GoToAuthorizationPage()
        {
            GoNextStep();
            previewPage.ConfirmGeneralForm();
        }
        public void GoToReminder()
        {
            GoNextStep();
            previewPage.RemindMeLater();
        }
       
        [Given(@"The user is a customer")]
        public void GivenTheUserIsACustomer()
        {
            Assert.AreEqual(Hooks.WebDriver.Url, Helper.StartPage);
        }

        [Given(@"The user is on the create book page")]
        public void GivenTheUserIsOnTheCreateBookPage()
        {
            
            Assert.AreEqual(Hooks.WebDriver.Url, Helper.StartPage);
        }

        [When(@"The user fills correct data to fields as (.*) , (.*) , (.*) (.*) , (.*)")]
        public void WhenTheUserFillsCorrectDataToFieldsAs(string username, int numberMonth, int numberDay, int numberSex, int numberCharacter)
        {
           // createBookData = new CreateBookData(username, Convert.ToInt32(numberMonth), Convert.ToInt32(numberDay), Convert.ToInt32(numberSex), Convert.ToInt32(numberCharacter));
            createBookPage.LoginNameAndDate(username, numberMonth, numberDay);
            createBookPage.LoginPersonCharacter(numberSex, numberCharacter);

        }

        [Then(@"The user is redirected to the preview page")]
        public void ThenTheUserIsRedirectedToThePreviewPage()
        {
            Assert.AreEqual(Hooks.WebDriver.Url, nextPageTitle); 
        }

        [Then(@"The field ""(.*)"" gets a red border\.")]
        public void ThenTheFieldGetsARedBorder_(string fieldName)
        {
            createBookPage.VerifyErrorField(fieldName);
        }

        [When(@"The user fills correct data to fields without choosing the button Gender")]
        public void WhenTheUserFillsCorrectDataToFieldsWithoutChoosingTheButtonAs(string gender)
        {
            createBookPage.VerifyErrorField(gender);
        }
        
        [When(@"The user fills incorrect data to field Name and correct data for another fields as (.*) , (.*) , (.*) (.*) , (.*)")]
        public void WhenTheUserFillsIncorrectDataToFieldNameAndCorrectDataForAnotherFieldsAs(string username, int numberMonth, int numberDay, int numberSex, int numberCharacter)
        {
            createBookPage.LoginNameAndDate(username, numberMonth, numberDay);
            createBookPage.LoginPersonCharacter(numberSex, numberCharacter);
        }

        [Then(@"The field for (.*) with incorrect data get a red border\.")]
        public void ThenTheFieldForWithIncorrectDataGetARedBorder_(string fieldName)
        {
            createBookPage.VerifyErrorField(fieldName);
        }
        
        [Then(@"The user  isn`t redirected to the preview page")]
        public void ThenTheUserIsnTRedirectedToThePreviewPage()
        {
            Assert.AreNotEqual(Hooks.WebDriver.Url, nextPageTitle);
        }

        [Then(@"The field (.*) gets a red border\.")]
        public void ThenTheFieldFirstNameGetsARedBorder_(string fieldName)
        {
            createBookPage.VerifyErrorField(fieldName);
        }

        [When(@"The user fills correct data to fields name and date as (.*) , (.*) , (.*)")]
        public void WhenTheUserFillsCorrectDataToFieldsNameAndDateAs(string username, int numberMonth, int numberDay)
        {
            createBookPage.LoginNameAndDate(username, numberMonth, numberDay);
        }

        [When(@"The user fills correct data to field Gender as (.*) , (.*)")]
        public void WhenTheUserFillsCorrectDataToFieldGenderAs(int numberSex, int numberCharacter)
        {
            createBookPage.LoginPersonCharacter(numberSex, numberCharacter);
        }

        [When(@"The user fills correct data to fields and the field First name is empty: (.*) , (.*) , (.*)")]
        public void WhenTheUserFillsCorrectDataToFieldsAndTheFieldFirstNameIsEmpty(string username, int numberMonth, int numberDay)
        {
            createBookPage.LoginNameAndDate(username, numberMonth, numberDay);
        }

        [When(@"The user fills correct data to fields without choosing the button ""(.*)"" : (.*) , (.*) , (.*)")]
        public void WhenTheUserFillsCorrectDataToFieldsWithoutChoosingTheButton(string fieldName, string username, int numberMonth, int numberDay)
        {
            createBookPage.LoginNameAndDate(username, numberMonth, numberDay);
            createBookPage.VerifyErrorField(fieldName);
        }
        
        [Then(@"The button ""(.*)"" gets a red border\.")]
        public void ThenTheButtonGetsARedBorder_(string fieldName)
        {
            createBookPage.VerifyErrorField(fieldName);
        }

        [When(@"The user fills correct data to field name as '(.*)' besides fields for birthday as month and day")]
        public void WhenTheUserFillsCorrectDataToFieldNameAsBesidesFieldsForBirthdayAsMonthAndDay(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user fills correct data to fields without choosing the option Character option: (.*) , (.*) , (.*) (.*)")]
        public void WhenTheUserFillsCorrectDataToFieldsWithoutChoosingTheOptionCharacterOption(string p0, string p1, string p2, string p3)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
