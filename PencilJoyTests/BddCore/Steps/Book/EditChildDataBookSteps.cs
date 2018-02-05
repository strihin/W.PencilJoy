﻿using System;
using NUnit.Framework;
using OpenQA.Selenium;
using PencilJoyTests.BddCore.steps;
using PencilJoyTests.Data;
using PencilJoyTests.Pages;
using TechTalk.SpecFlow;

namespace PencilJoyTests.BddCore.Steps
{
    [Binding]
    public class EditingAboutChildSDataForABookSteps
    {
        
        private CreateBookData createBookData;
        private EditBookPage editPage = new EditBookPage();
        private FillChildDataSteps childDataSteps = new FillChildDataSteps();
    
        private const string previewPageTitle = Helper.StartPage + "preview";
        private const string bagPageTitle = Helper.StartPage + "bag";
        private const string editPageTitle = Helper.StartPage + "edit";


        [Given(@"The user is on the preview page")]
        public void GivenTheUserIsOnThePreviewPage()
        {
            childDataSteps.GoNextStep();
            Assert.AreEqual(Hooks.WebDriver.Url, previewPageTitle);
        }
        
        [Given(@"The user is on the bag page")]
        public void GivenTheUserIsOnTheBagPage()
        {
            childDataSteps.GoNextStep();
            childDataSteps.GoToAuthorizationPage();
            Assert.AreEqual(Hooks.WebDriver.Url, bagPageTitle);
        }
        
        [Given(@"The user is on the edit book page")]
        public void GivenTheUserIsOnTheEditBookPage()
        {
            childDataSteps.GoNextStep();
            childDataSteps.GoToEditBookPage();
            Assert.AreEqual(Hooks.WebDriver.Url, editPageTitle);
        }
        
        [When(@"The user edits fields with correct data to fields name and date as (.*) , (.*) , (.*)")]
        public void WhenTheUserEditsFieldsWithCorrectDataToFieldsNameAndDateAs(string username, int numberMonth, int numberDay)
        {
            editPage.LoginNameAndDate(username, numberMonth, numberDay);
        }
        
        [When(@"The user edits fields with correct data to field Gender as (.*) , (.*)")]
        public void WhenTheUserEditsFieldsWithCorrectDataToFieldGenderAs(int numberSex, int numberCharacter)
        {
            editPage.LoginPersonCharacter(numberSex, numberCharacter);
        }
        
        [When(@"The user clicks the button Update Changes")]
        public void WhenTheUserClicksTheButtonUpdateChanges()
        {
            editPage.ConfirmForm();
        }
        
        [When(@"The user isn`t edit fields")]
        public void WhenTheUserIsnTEditFields() { }
        
        [When(@"The user edits fields with incorrect data to fields name and date as (.*) , (.*) , (.*)")]
        public void WhenTheUserEditsFieldsWithIncorrectDataToFieldsNameAndDateAs(string username, int numberMonth, int numberDay)
        {
            editPage.LoginNameAndDate(username, numberMonth, numberDay);
        }
        
        [When(@"The user edits fields with incorrect data to field Gender as (.*) , (.*)")]
        public void WhenTheUserEditsFieldsWithIncorrectDataToFieldGenderAs(int numberSex, int numberCharacter)
        {
            editPage.LoginPersonCharacter(numberSex, numberCharacter);
        }
        
        [Then(@"The user is redirected to edit page\.")]
        public void ThenTheUserIsRedirectedToEditPage_()
        {
            Assert.AreEqual(Hooks.WebDriver.Url, editPageTitle);
        }
        
        [Then(@"The user is redirected to preview page with changing data\.")]
        public void ThenTheUserIsRedirectedToPreviewPageWithChangingData_(Table table)
        {
            Assert.AreEqual(Hooks.WebDriver.Url, previewPageTitle);
        }
        
        [Then(@"The user is redirected to preview page without changing data\.")]
        public void ThenTheUserIsRedirectedToPreviewPageWithoutChangingData_()
        {
            Assert.AreEqual(Hooks.WebDriver.Url, previewPageTitle);
        }
        
        [Then(@"The user isn`t redirected to preview page with changing data\.")]
        public void ThenTheUserIsnTRedirectedToPreviewPageWithChangingData_(Table table)
        {
            Assert.AreEqual(Hooks.WebDriver.Url, editPageTitle);
        }

        [When(@"The user clicks to the button Edit book")]
        public void WhenTheUserClicksToTheButtonEditBook()
        {

        }
    }
}
