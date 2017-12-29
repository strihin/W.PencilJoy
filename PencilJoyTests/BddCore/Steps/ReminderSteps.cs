using System;
using NUnit.Framework;
using OpenQA.Selenium;
using PencilJoyTests.Pages;
using TechTalk.SpecFlow;

namespace PencilJoyTests.BddCore.Steps
{
    [Binding]
    public class VerifyReminderSteps
    {
        private IWebDriver currentDriver;
        internal PreviewPage previewPage = new PreviewPage();
        
        [Given(@"The popup Remind me later should be appear")]
        public void GivenThePopupRemindMeLaterShouldBeAppear()
        {
            previewPage.RemindMeLater();
            Assert.IsTrue(previewPage.IsPopupRemindMeLaterAppear());
        }
        
        [Given(@"The popup Your reminder is set should be appear")]
        public void GivenThePopupYourReminderIsSetShouldBeAppear()
        {
            previewPage.IsSuccessPopupAppear();
        }
        
        [Given(@"The user fills the field Your email with correct data as (.*)")]
        public void GivenTheUserFillsTheFieldYourEmailWithCorrectDataAs(string email)
        {
            previewPage.FillEmailToPopup(email);
        }
      
        [When(@"The user clicks the button X")]
        public void WhenTheUserClicksTheButtonX()
        {
            previewPage.ClosePopupRemindMeLater();
        }
        
        [When(@"The user clicks the button Set reminder")]
        public void WhenTheUserClicksTheButtonSetReminder()
        {
            previewPage.CofirmFormInPopupRemindMeLater();
        }
        
        [When(@"The user fills the field Your email with correct data as (.*)")]
        public void WhenTheUserFillsTheFieldYourEmailWithCorrectDataAs(string email)
        {
            previewPage.FillEmailToPopup(email);
        }
        
        [Then(@"The popup Remind me later should be appear")]
        public void ThenThePopupRemindMeLaterShouldBeAppear()
        {
            Assert.IsTrue(previewPage.IsPopupRemindMeLaterAppear());
        }
        
        [Then(@"The popup Remind me later should be disappear")]
        public void ThenThePopupRemindMeLaterShouldBeDisappear()
        {
            Assert.IsFalse(previewPage.IsPopupRemindMeLaterAppear());
        }

        [Then(@"The popup Your reminder is set should not be appear")]
        [Then(@"The popup Your reminder is set should be disappear")]
        public void ThenThePopupYourReminderIsSetShouldBeDisappear()
        {
            Assert.IsFalse(previewPage.IsPopupRemindSetDisplayed());
        }
        
        [Then(@"The popup Your reminder is set should be appear")]
        public void ThenThePopupYourReminderIsSetShouldBeAppear()
        {
            Assert.IsTrue(previewPage.IsPopupRemindSetDisplayed());
        }
        
        [Then(@"The fiels Your email should get red border")]
        public void ThenTheFielsYourEmailShouldGetRedBorder()
        {
            Assert.IsTrue(previewPage.IsEmailValid());
        }
        
        [Then(@"The textbox for datepicker should get red border")]
        public void ThenTheTextboxForDatepickerShouldGetRedBorder()
        {
            Assert.IsFalse(previewPage.IsDataPickerDisplayed());
        }
        
        [Then(@"The block with the red text ""(.*)"" should be appear")]
        public void ThenTheBlockWithTheRedTextShouldBeAppear(string messageError)
        {
           Assert.IsTrue(previewPage.IsMessageError(messageError));
        }

       
        [When(@"The user clicks the button Remind me later")]
        public void WhenTheUserClicksTheButtonRemindMeLater()
        {
            previewPage.RemindMeLater();
        }

        [Then(@"The string in the popup Your reminder is set should have value as (.*)")]
        public void ThenTheStringInThePopupYourReminderIsSetShouldHaveValueAs(string email)
        {
            Assert.IsTrue(previewPage.IsEmailCorrect(email));
        }

        [When(@"The user fills date in the datepicker")]
        public void WhenTheUserFillsDateInTheDatepicker()
        {
            previewPage.FillDatePicker();
        }
  
        [When(@"The user clicks the checkbox ""(.*)""")]
        [Given(@"The user clicks the checkbox ""(.*)""")]
        public void GivenTheUserClicksTheCheckbox(string checkboxText)
        {
            previewPage.SelectCheckbox(checkboxText);
        }

    }
}
