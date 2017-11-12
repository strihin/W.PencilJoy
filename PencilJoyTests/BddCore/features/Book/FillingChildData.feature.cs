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
namespace PencilJoyTests.BddCore.Features.Book
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Filling about child\'s data for a book")]
    public partial class FillingAboutChildsDataForABookFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FillingChildData.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Filling about child\'s data for a book", "\tIn order to fill about child\'s data \r\n\tAs a customer\r\n\tThe user wants the system" +
                    " applies filled child\'s data for a book", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("The user fills fields about child\'s data with correct data")]
        [NUnit.Framework.CategoryAttribute("positive")]
        public virtual void TheUserFillsFieldsAboutChildsDataWithCorrectData(string username, string numberMonth, string numberDay, string numberSex, string numberCharacter, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "positive"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user fills fields about child\'s data with correct data", @__tags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And("The user is on the create book page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.When(string.Format("The user fills correct data to fields as {0} , {1} , {2} {3} , {4}", username, numberMonth, numberDay, numberSex, numberCharacter), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("The user is redirected to the preview page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user fills fields about child\'s data without fields for birthday")]
        [NUnit.Framework.CategoryAttribute("positive")]
        public virtual void TheUserFillsFieldsAboutChildsDataWithoutFieldsForBirthday()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user fills fields about child\'s data without fields for birthday", new string[] {
                        "positive"});
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
 testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
 testRunner.And("The user is on the create book page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.When("The user fills correct data to all fields besides fields for birthday as month an" +
                    "d day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.Then("The user is redirected to the preview page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user fills fields about child\'s data with incorrect data")]
        [NUnit.Framework.CategoryAttribute("negative")]
        public virtual void TheUserFillsFieldsAboutChildsDataWithIncorrectData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user fills fields about child\'s data with incorrect data", new string[] {
                        "negative"});
#line 24
this.ScenarioSetup(scenarioInfo);
#line 25
 testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
 testRunner.And("The user is on the create book page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.When("The user fills incorrect data to fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then("The user doesn`t redirected to the preview page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.And("The fields with incorrect data gets a red border.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user fills fields about child\'s data without the field \"First name\"")]
        [NUnit.Framework.CategoryAttribute("negative")]
        public virtual void TheUserFillsFieldsAboutChildsDataWithoutTheFieldFirstName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user fills fields about child\'s data without the field \"First name\"", new string[] {
                        "negative"});
#line 32
this.ScenarioSetup(scenarioInfo);
#line 33
 testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
 testRunner.And("The user is on the create book page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.When("The user fills correct data to fields besides the field \"First name\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.And("The user leaves the field \"First name\" empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.Then("The user doesn`t redirected to the preview page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
 testRunner.And("The field \"First name\" gets a red border.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user fills fields about child\'s data without the field \"Gender\"")]
        [NUnit.Framework.CategoryAttribute("negative")]
        public virtual void TheUserFillsFieldsAboutChildsDataWithoutTheFieldGender()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user fills fields about child\'s data without the field \"Gender\"", new string[] {
                        "negative"});
#line 41
this.ScenarioSetup(scenarioInfo);
#line 42
 testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 43
 testRunner.And("The user is on the create book page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.When("The user fills correct data to fields without choosing the button \"Gender\" as \"Bo" +
                    "y\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
 testRunner.Then("The user doesn`t redirected to the preview page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
 testRunner.And("The buttons \"Boy\", \"Girl\" get a red border.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user fills fields about child\'s data without the option \"Character option\"")]
        [NUnit.Framework.CategoryAttribute("negative")]
        public virtual void TheUserFillsFieldsAboutChildsDataWithoutTheOptionCharacterOption()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user fills fields about child\'s data without the option \"Character option\"", new string[] {
                        "negative"});
#line 49
this.ScenarioSetup(scenarioInfo);
#line 50
 testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 51
 testRunner.And("The user is on the create book page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.When("The user fills correct data to fields without choosing the option \"Character opti" +
                    "on\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.Then("The user doesn`t redirected to the preview page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 54
 testRunner.And("The buttons \"Boy\", \"Girl\" get a red border.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion