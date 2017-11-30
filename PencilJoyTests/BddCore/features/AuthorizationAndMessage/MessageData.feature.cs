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
    [NUnit.Framework.DescriptionAttribute("Actions for message field of a book")]
    public partial class ActionsForMessageFieldOfABookFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MessageData.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Actions for message field of a book", "\tIn order to fill, edit, remove message data\r\n\tAs a customer\r\n\tI want the system " +
                    "applies filled data of a book", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("The user fills empty message field with correct data")]
        [NUnit.Framework.CategoryAttribute("positive")]
        [NUnit.Framework.CategoryAttribute("emptyMessage")]
        [NUnit.Framework.TestCaseAttribute("", null)]
        public virtual void TheUserFillsEmptyMessageFieldWithCorrectData(string message, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "positive",
                    "emptyMessage"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user fills empty message field with correct data", @__tags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And("The user is on the message page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("The user fills authorization fields with correct data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.When(string.Format("The user clears existing message as {0}", message), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.And("The user fills text for it", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And("The user click the button \"Next\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.Then("The user is redirected to the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user adds to existing message correct text to the end of the message")]
        [NUnit.Framework.CategoryAttribute("positive")]
        [NUnit.Framework.CategoryAttribute("endMessage")]
        [NUnit.Framework.TestCaseAttribute("Duis consequat dui nec nisi volutpat eleifend", null)]
        public virtual void TheUserAddsToExistingMessageCorrectTextToTheEndOfTheMessage(string message, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "positive",
                    "endMessage"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user adds to existing message correct text to the end of the message", @__tags);
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
 testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
 testRunner.And("The user is on the message page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.And("The user fills authorization fields with correct data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.When(string.Format("The user adds to existing message correct text to the end of the message as {0}", message), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.And("The user click the button \"Next\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.Then("The user is redirected to the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user adds to existing message correct text to the start of the message")]
        [NUnit.Framework.CategoryAttribute("positive")]
        [NUnit.Framework.CategoryAttribute("startMessage")]
        [NUnit.Framework.TestCaseAttribute("Nullam sit amet turpis elementum", null)]
        public virtual void TheUserAddsToExistingMessageCorrectTextToTheStartOfTheMessage(string message, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "positive",
                    "startMessage"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user adds to existing message correct text to the start of the message", @__tags);
#line 32
this.ScenarioSetup(scenarioInfo);
#line 33
 testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
 testRunner.And("The user is on the message page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("The user fills authorization fields with correct data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.When(string.Format("The user adds to existing message correct text to the start of the message as {0}" +
                        "", message), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.And("The user click the button \"Next\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.Then("The user is redirected to the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user adds to existing message correct text to the middle of the message")]
        [NUnit.Framework.CategoryAttribute("positive")]
        [NUnit.Framework.CategoryAttribute("middleMessage")]
        [NUnit.Framework.TestCaseAttribute("Cras non velit nec nisi vulputate nonummy", null)]
        public virtual void TheUserAddsToExistingMessageCorrectTextToTheMiddleOfTheMessage(string message, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "positive",
                    "middleMessage"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user adds to existing message correct text to the middle of the message", @__tags);
#line 44
this.ScenarioSetup(scenarioInfo);
#line 45
 testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 46
 testRunner.And("The user is on the message page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.And("The user fills authorization fields with correct data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.When(string.Format("The user adds to existing message correct text to the middle of the message as {0" +
                        "}", message), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
 testRunner.And("The user click the button \"Next\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.Then("The user is redirected to the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user doesn`t change existing message")]
        [NUnit.Framework.CategoryAttribute("positive")]
        [NUnit.Framework.CategoryAttribute("defaultMessage")]
        public virtual void TheUserDoesnTChangeExistingMessage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user doesn`t change existing message", new string[] {
                        "positive",
                        "defaultMessage"});
#line 56
this.ScenarioSetup(scenarioInfo);
#line 57
 testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 58
 testRunner.And("The user is on the message page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.And("The user fills authorization fields with correct data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.When("The user doesn`t change existing message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.And("The user click the button \"Next\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.Then("The user is redirected to the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
