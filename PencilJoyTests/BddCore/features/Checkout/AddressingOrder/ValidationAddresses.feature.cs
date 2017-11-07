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
namespace PencilJoyTests.BddCore.Features.Checkout.AddressingOrder
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Order addressing validation")]
    [NUnit.Framework.CategoryAttribute("checkout")]
    public partial class OrderAddressingValidationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ValidationAddresses.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Order addressing validation", "    In order to avoid making mistakes when addressing an order\r\n    As an Custome" +
                    "r\r\n    I want to be prevented from adding it without specifying required fields " +
                    "and checked incorrect data to fields", ProgrammingLanguage.CSharp, new string[] {
                        "checkout"});
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
        [NUnit.Framework.DescriptionAttribute("The user removes value for fields in the block \"Shipping Address\"")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.CategoryAttribute("validation")]
        [NUnit.Framework.CategoryAttribute("shipping")]
        public virtual void TheUserRemovesValueForFieldsInTheBlockShippingAddress()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user removes value for fields in the block \"Shipping Address\"", new string[] {
                        "negative",
                        "validation",
                        "shipping"});
#line 8
 this.ScenarioSetup(scenarioInfo);
#line 9
  testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
  testRunner.And("The user is on checkout page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
  testRunner.And("The user fills fields for shipping address with data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
  testRunner.When("The user edits the field \"Last name\" in the block \"Shipping address\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
  testRunner.Then("The field \"Last name\" should be empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Shipping address without any filling fields")]
        [NUnit.Framework.CategoryAttribute("ui")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.CategoryAttribute("shipping")]
        public virtual void ShippingAddressWithoutAnyFillingFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Shipping address without any filling fields", new string[] {
                        "ui",
                        "negative",
                        "shipping"});
#line 16
    this.ScenarioSetup(scenarioInfo);
#line 17
        testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 18
        testRunner.And("The user is on checkout page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
        testRunner.When("The user does not specify any shipping address information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
        testRunner.And("The user  tries to complete the addressing step", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
        testRunner.Then("The user should be notified that all fields in shipping details are required such" +
                    " as FIRST NAME, LAST NAME, STREET ADDRESS, CITY, STATE/REGION, POSTCODE / ZIP CO" +
                    "DE, COUNTRY, PHONE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Billing address without any filling fields")]
        [NUnit.Framework.CategoryAttribute("ui")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.CategoryAttribute("billing")]
        public virtual void BillingAddressWithoutAnyFillingFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Billing address without any filling fields", new string[] {
                        "ui",
                        "negative",
                        "billing"});
#line 24
    this.ScenarioSetup(scenarioInfo);
#line 25
        testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
        testRunner.And("The user is on checkout page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
  testRunner.And("The user clicks the checkbox \"Bill to this address\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
        testRunner.When("The user does not specify any billing address information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
        testRunner.And("The user  tries to complete the addressing step", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
        testRunner.Then("The user should be notified that all fields in billing details are required such " +
                    "as FIRST NAME, LAST NAME, STREET ADDRESS, CITY, STATE/REGION, POSTCODE / ZIP COD" +
                    "E, COUNTRY, PHONE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Shipping address without the first name and the last name")]
        [NUnit.Framework.CategoryAttribute("ui")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.CategoryAttribute("shipping")]
        public virtual void ShippingAddressWithoutTheFirstNameAndTheLastName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Shipping address without the first name and the last name", new string[] {
                        "ui",
                        "negative",
                        "shipping"});
#line 33
    this.ScenarioSetup(scenarioInfo);
#line 34
        testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 35
        testRunner.And("The user is on checkout page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
        testRunner.When("The user specifies  in shipping address all fields becides the first name and the" +
                    " last name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
        testRunner.And("The user  tries to complete the addressing step", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
        testRunner.Then("The user should be notified that the \"first name\" and the \"last name\" in shipping" +
                    " details are required", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Billing address without the first name and the last name")]
        [NUnit.Framework.CategoryAttribute("ui")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.CategoryAttribute("billing")]
        public virtual void BillingAddressWithoutTheFirstNameAndTheLastName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Billing address without the first name and the last name", new string[] {
                        "ui",
                        "negative",
                        "billing"});
#line 41
    this.ScenarioSetup(scenarioInfo);
#line 42
        testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 43
        testRunner.And("The user is on checkout page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
  testRunner.And("The user clicks the checkbox \"Bill to this address\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
  testRunner.And("The user clicks the checkbox \"Ship to this address\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
        testRunner.When("The user specifies  in billing address all fields becides the first name and the " +
                    "last name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
        testRunner.And("The user  tries to complete the addressing step", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
        testRunner.Then("The user should be notified that the \"first name\" and the \"last name\" in billing " +
                    "details are required", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Billing address without the city and the postcode / zip code and Shipping address" +
            " without the Phone")]
        [NUnit.Framework.CategoryAttribute("ui")]
        [NUnit.Framework.CategoryAttribute("negative")]
        public virtual void BillingAddressWithoutTheCityAndThePostcodeZipCodeAndShippingAddressWithoutThePhone()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Billing address without the city and the postcode / zip code and Shipping address" +
                    " without the Phone", new string[] {
                        "ui",
                        "negative"});
#line 51
    this.ScenarioSetup(scenarioInfo);
#line 52
        testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 53
        testRunner.And("The user is on checkout page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
  testRunner.And("The user clicks the checkbox \"Bill to this address\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
        testRunner.When("The user specifies  in billing address all fields becides the city and the postco" +
                    "de / zip code", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
  testRunner.And("The user specifies  in shipping address all fields becides the Phone", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
        testRunner.And("The user  tries to complete the addressing step", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
        testRunner.Then("The user should be notified that the \"the city\" and \"the postcode /zip code\" in b" +
                    "illing details are required", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
  testRunner.And("The user should be notified that the \"the Phone\" in shipping details isrequired", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Shipping address with the Phone as string")]
        [NUnit.Framework.CategoryAttribute("ui")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.CategoryAttribute("shipping")]
        public virtual void ShippingAddressWithThePhoneAsString()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Shipping address with the Phone as string", new string[] {
                        "ui",
                        "negative",
                        "shipping"});
#line 62
    this.ScenarioSetup(scenarioInfo);
#line 63
        testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 64
        testRunner.And("The user is on checkout page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
        testRunner.When("The user specifies  in shipping address all fields with correct data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 66
  testRunner.And("The user specifies  in shipping address the field \"Phone\" with string as \"three-t" +
                    "wo-one-one\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
        testRunner.And("The user  tries to complete the addressing step", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
        testRunner.Then("The user should be notified that the \"Phone\" in shipping details should be numeri" +
                    "c value, no string value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Billing address with the Phone as string")]
        [NUnit.Framework.CategoryAttribute("ui")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.CategoryAttribute("billing")]
        public virtual void BillingAddressWithThePhoneAsString()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Billing address with the Phone as string", new string[] {
                        "ui",
                        "negative",
                        "billing"});
#line 71
    this.ScenarioSetup(scenarioInfo);
#line 72
        testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 73
        testRunner.And("The user is on checkout page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
  testRunner.And("The user clicks the checkbox \"Bill to this address\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
        testRunner.When("The user specifies  in billing address all fields with correct data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
  testRunner.And("The user specifies  in billing address the field \"Phone\" with string as \"three-tw" +
                    "o-one-one\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
        testRunner.And("The user  tries to complete the addressing step", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
        testRunner.Then("The user should be notified that the \"Phone\" in billing details should be numeric" +
                    " value, no string value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
