using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace PencilJoyTests.BddCore.Steps
{
    [Binding]
    public sealed class MessageSteps
    {
        [Given(@"The user fills authorization fields with correct data")]
        public void GivenTheUserFillsAuthorizationFieldsWithCorrectData()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user clears existing message")]
        public void WhenTheUserClearsExistingMessage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user fills text for it")]
        public void WhenTheUserFillsTextForIt()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user click the button ""(.*)""")]
        public void WhenTheUserClickTheButton(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user adds to existing message correct text to the end of the message as (.*)")]
        public void WhenTheUserAddsToExistingMessageCorrectTextToTheEndOfTheMessageAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user adds to existing message correct text to the start of the message")]
        public void WhenTheUserAddsToExistingMessageCorrectTextToTheStartOfTheMessage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user adds to existing message correct text to the middle of the message")]
        public void WhenTheUserAddsToExistingMessageCorrectTextToTheMiddleOfTheMessage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"The user doesn`t change existing message")]
        public void WhenTheUserDoesnTChangeExistingMessage()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
