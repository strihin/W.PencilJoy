using System;
using TechTalk.SpecFlow;

namespace PencilJoyTests
{
    [Binding]
    public class FillingCustomerSDataForAuthorizationSteps
    {
        [When(@"The user fills data for fields, which exists in DB  as Auroora Dauncey , qaengineer(.*)@yahoo\.com")]
        public void WhenTheUserFillsDataForFieldsWhichExistsInDBAsAurooraDaunceyQaengineerYahoo_Com(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
