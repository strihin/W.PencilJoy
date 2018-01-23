﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace PencilJoyTests.BddCore.Features.AuthorizationAndMessage
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Filling customer`s data for authorization")]
    public partial class FillingCustomerSDataForAuthorizationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Authorization.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Filling customer`s data for authorization", "\tIn order to fill authorization data\r\n\tAs a customer\r\n\tThe user wants the system " +
                    "applies filled data for authorization", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user fills data for new authorization with correct data")]
        [NUnit.Framework.CategoryAttribute("positive")]
        [NUnit.Framework.CategoryAttribute("newcustomer")]
        [NUnit.Framework.TestCaseAttribute("Mano Eyam", "mey+-a.M_7@icq.com", null)]
        [NUnit.Framework.TestCaseAttribute("Fannie Lillow", "8fli.l.l.ow8@php.net", null)]
        [NUnit.Framework.TestCaseAttribute("Gonzales Spenton", "gspenton9@cbsnews.com", null)]
        [NUnit.Framework.TestCaseAttribute("Mommy Hummerston", "mhummerstona@enga-dget.com", null)]
        [NUnit.Framework.TestCaseAttribute("Bill Goldby", "bgoldbyb@ly.co.s.com", null)]
        [NUnit.Framework.TestCaseAttribute("Alphard Fears", "afearsc@nature.com", null)]
        [NUnit.Framework.TestCaseAttribute("Auroora Dauncey", "adaunceyd@seesaa.net", null)]
        [NUnit.Framework.TestCaseAttribute("Rosalind Abramson", "rabramsone@webeden.co.uk", null)]
        [NUnit.Framework.TestCaseAttribute("Ivan Marienko", "ivan@марья.рф", null)]
        [NUnit.Framework.TestCaseAttribute("Muslim Ivanov", "ivan@اتصالات‎.اتصالات‎", null)]
        public virtual void TheUserFillsDataForNewAuthorizationWithCorrectData(string fullName, string email, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "positive",
                    "newcustomer"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user fills data for new authorization with correct data", @__tags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("The user is a new user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And("The user is on the message page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("The active tab is the New customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.When(string.Format("The user fills correct data for fields  as {0} , {1}", fullName, email), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.And("The user clicks the button Next", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.Then("The user is redirected to the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user fills data for new authorization with existing data in DB")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.CategoryAttribute("newcustomer")]
        [NUnit.Framework.TestCaseAttribute("Auroora Dauncey", "qaengineer6@yahoo.com", null)]
        [NUnit.Framework.TestCaseAttribute("Birgit Drennan", "qaengineer7@yahoo.com", null)]
        [NUnit.Framework.TestCaseAttribute("Casi Demo", "demo@altsolution.net", null)]
        public virtual void TheUserFillsDataForNewAuthorizationWithExistingDataInDB(string fullName, string email, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "negative",
                    "newcustomer"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user fills data for new authorization with existing data in DB", @__tags);
#line 28
this.ScenarioSetup(scenarioInfo);
#line 29
 testRunner.Given("The user is a new user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 30
 testRunner.And("The user is on the message page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.And("The active tab is the New customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.When(string.Format("The user fills data for fields, which exists in DB as \'{0}\', \'{1}\'", fullName, email), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
 testRunner.And("The user clicks the button Next", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.Then("The user isn`t redirected to the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user fills data for new authorization with invalid mail")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.CategoryAttribute("newcustomer")]
        [NUnit.Framework.CategoryAttribute("validation")]
        [NUnit.Framework.TestCaseAttribute("Rivy Vasishchev", ".rvasishchevf@amazonaws.com", null)]
        [NUnit.Framework.TestCaseAttribute("Rayner Biggin", "rbigging.@about.me", null)]
        [NUnit.Framework.TestCaseAttribute("Hamilton Witherden", "\"hwitherdenh\"@netscape.com", null)]
        [NUnit.Framework.TestCaseAttribute("Birgit Drennan", "bdr@ennani@suncom", null)]
        [NUnit.Framework.TestCaseAttribute("Augustine Puden", "apudenj@-myspace.com", null)]
        [NUnit.Framework.TestCaseAttribute("Udale Ballsdon", "uballsdonk@so-net-.ne.jp", null)]
        [NUnit.Framework.TestCaseAttribute("Archer Spittle", "aspittlel@privacy..au", null)]
        [NUnit.Framework.TestCaseAttribute("Ivan Marienko", "иван@марья.рф", null)]
        public virtual void TheUserFillsDataForNewAuthorizationWithInvalidMail(string fullName, string email, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "negative",
                    "newcustomer",
                    "validation"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user fills data for new authorization with invalid mail", @__tags);
#line 43
this.ScenarioSetup(scenarioInfo);
#line 44
 testRunner.Given("The user is a new user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
 testRunner.And("The user is on the message page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.And("The active tab is the New customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.When(string.Format("The user fills correct name and invalid email as {0} , {1}", fullName, email), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
 testRunner.And("The user clicks the button Next", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.Then("The user isn`t redirected to the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user isn`t fill data for new authorization")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.CategoryAttribute("newcustomer")]
        [NUnit.Framework.TestCaseAttribute("", "", null)]
        [NUnit.Framework.TestCaseAttribute("Alex", "", null)]
        [NUnit.Framework.TestCaseAttribute("", "tes@test.test", null)]
        public virtual void TheUserIsnTFillDataForNewAuthorization(string fullName, string email, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "negative",
                    "newcustomer"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user isn`t fill data for new authorization", @__tags);
#line 62
this.ScenarioSetup(scenarioInfo);
#line 63
 testRunner.Given("The user is a new user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 64
 testRunner.And("The user is on the message page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.And("The active tab is the New customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.When("The user isn`t fill data for fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
 testRunner.And("The user clicks the button Next", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.Then("The user isn`t redirected to the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user fills data for registrated account before with correct data")]
        [NUnit.Framework.CategoryAttribute("positive")]
        [NUnit.Framework.CategoryAttribute("returningcustomer")]
        [NUnit.Framework.TestCaseAttribute("qaengineer6@yahoo.com", "1q1q1q", null)]
        [NUnit.Framework.TestCaseAttribute("qaengineer7@yahoo.com", "1q1q1q", null)]
        [NUnit.Framework.TestCaseAttribute("demo@altsolution.net", "1q1q1q", null)]
        public virtual void TheUserFillsDataForRegistratedAccountBeforeWithCorrectData(string email, string password, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "positive",
                    "returningcustomer"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user fills data for registrated account before with correct data", @__tags);
#line 76
this.ScenarioSetup(scenarioInfo);
#line 77
 testRunner.Given("The user is a registrated user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 78
 testRunner.And("The user is on the message page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And("The user clicks the tab Returning customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.When(string.Format("The user fills data for fields, which exists in DB as {0}, {1}", email, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
 testRunner.And("The user clicks the button Next", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.Then("The user is redirected to the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user fills data for registrated account before with expitrd data")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.CategoryAttribute("returningcustomer")]
        [NUnit.Framework.TestCaseAttribute("qaengineer9@ukr.net", "1q1q1q", null)]
        public virtual void TheUserFillsDataForRegistratedAccountBeforeWithExpitrdData(string email, string password, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "negative",
                    "returningcustomer"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user fills data for registrated account before with expitrd data", @__tags);
#line 91
this.ScenarioSetup(scenarioInfo);
#line 92
 testRunner.Given("The user is a registrated user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 93
 testRunner.And("The user is on the message page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.And("The user clicks the tab Returning customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
 testRunner.When(string.Format("The user fills data for fields for expired account as {0}, {1}", email, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 96
 testRunner.And("The user clicks the button Next", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.Then("The user isn`t redirected to the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user fills data for registrated account before with no existing data")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.CategoryAttribute("returningcustomer")]
        [NUnit.Framework.TestCaseAttribute("lgillisq@soundcloud.com", "pass10383", null)]
        [NUnit.Framework.TestCaseAttribute("gbaumer@fc2.com", "baumerosen202", null)]
        public virtual void TheUserFillsDataForRegistratedAccountBeforeWithNoExistingData(string email, string password, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "negative",
                    "returningcustomer"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user fills data for registrated account before with no existing data", @__tags);
#line 103
this.ScenarioSetup(scenarioInfo);
#line 104
 testRunner.Given("The user is a registrated user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 105
 testRunner.And("The user is on the message page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
 testRunner.And("The user clicks the tab Returning customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
 testRunner.When(string.Format("The user fills data for fields, which no exists in DB as  {0}, {1}", email, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 108
 testRunner.And("The user clicks the button Next", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
 testRunner.Then("The user isn`t redirected to the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user fills data for registrated account before with invalid password")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.CategoryAttribute("returningcustomer")]
        [NUnit.Framework.TestCaseAttribute("qaengineer6@yahoo.com", "1q1q", null)]
        [NUnit.Framework.TestCaseAttribute("qaengineer7@yahoo.com", "1q1 q1q", null)]
        [NUnit.Framework.TestCaseAttribute("demo@altsolution.net", "1q1q1q1q1", null)]
        public virtual void TheUserFillsDataForRegistratedAccountBeforeWithInvalidPassword(string email, string password, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "negative",
                    "returningcustomer"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user fills data for registrated account before with invalid password", @__tags);
#line 116
this.ScenarioSetup(scenarioInfo);
#line 117
 testRunner.Given("The user is a registrated user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 118
 testRunner.And("The user is on the message page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
 testRunner.And("The user clicks the tab Returning customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
 testRunner.When(string.Format("The user fills data for fields, which exists in DB  with incorrect password  as  " +
                        "{0}, {1}", email, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 121
 testRunner.And("The user clicks the button Next", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
 testRunner.Then("The user isn`t redirected to the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user fills data for registrated account before with invalid email")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.CategoryAttribute("returningcustomer")]
        [NUnit.Framework.TestCaseAttribute("qaengineer678@yahoo.com", "1q1q1q", null)]
        [NUnit.Framework.TestCaseAttribute("qaengineer7@yahoocom", "1q1q1q", null)]
        [NUnit.Framework.TestCaseAttribute("demoaltsolution.net", "1q1q1q", null)]
        [NUnit.Framework.TestCaseAttribute("akopsx@i2i.jp789", "1q1q1q", null)]
        [NUnit.Framework.TestCaseAttribute("bdelortygoodreads.com", "1q1q1q", null)]
        public virtual void TheUserFillsDataForRegistratedAccountBeforeWithInvalidEmail(string email, string password, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "negative",
                    "returningcustomer"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user fills data for registrated account before with invalid email", @__tags);
#line 130
this.ScenarioSetup(scenarioInfo);
#line 131
 testRunner.Given("The user is a registrated user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 132
 testRunner.And("The user is on the message page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
 testRunner.And("The user clicks the tab Returning customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 134
 testRunner.When(string.Format("The user fills data for fields, which exists in DB  with incorrect email  as  {0}" +
                        ", {1}", email, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 135
 testRunner.And("The user clicks the button Next", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
 testRunner.Then("The user isn`t redirected to the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
