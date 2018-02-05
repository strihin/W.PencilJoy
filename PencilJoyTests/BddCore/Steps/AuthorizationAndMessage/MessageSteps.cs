using OpenQA.Selenium;
using PencilJoyTests.BddCore.steps;
using PencilJoyTests.Pages;
using TechTalk.SpecFlow;

namespace PencilJoyTests.BddCore.Steps
{
    [Binding]
    public class MessageSteps
    {
        private FillChildDataSteps childDataSteps = new FillChildDataSteps();
        MessageAndIdentificationPage messagePage = new MessageAndIdentificationPage();
        private const string nextPageTitle = Helper.StartPage + "/bag";

        [Given(@"The user fills authorization fields with correct data")]
        public void GivenTheUserFillsAuthorizationFieldsWithCorrectData()
        {
            messagePage.LoginNewCustomer();
        }
        
        [When(@"The user clears existing message")]
        public void WhenTheUserClearsExistingMessage()
        {
            messagePage.ClearMessageField();
        }
        
        [When(@"The user fills text for it as ")]
        public void WhenTheUserFillsTextForItAs() { }
        
        [When(@"The user clicks the button Next")]
        public void WhenTheUserClickTheButtonNext()
        {
            messagePage.ComfirmForm();
        }
        
        [When(@"The user adds to existing message correct text to the end of the message as (.*)")]
        public void WhenTheUserAddsToExistingMessageCorrectTextToTheEndOfTheMessageAs(string textToTheEnd)
        {
            messagePage.AddTextToMessage(textToTheEnd, Keys.PageDown);
        }

        [When(@"The user adds to existing message correct text to the start of the message as (.*)")]
        public void WhenTheUserAddsToExistingMessageCorrectTextToTheStartOfTheMessageAs(string textToTheStart)
        {
            messagePage.AddTextToMessage(textToTheStart, Keys.PageUp);
        }

        [When(@"The user adds to existing message correct text to the middle of the message as (.*)")]
        public void WhenTheUserAddsToExistingMessageCorrectTextToTheMiddleOfTheMessageAs(string textToTheMiddle)
        {
            messagePage.AddTextToMessage(textToTheMiddle, Keys.End);
        }
        
        [When(@"The user doesn`t change existing message")]
        public void WhenTheUserDoesnTChangeExistingMessage() { }
    }
}
