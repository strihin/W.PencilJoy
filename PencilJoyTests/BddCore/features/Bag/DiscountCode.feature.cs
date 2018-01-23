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
namespace PencilJoyTests.BddCore.Features.Bag
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Verify discount code for order")]
    public partial class VerifyDiscountCodeForOrderFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DiscountCode.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Verify discount code for order", "\tIn order to fill discount code on the bag page\r\n\tAs a customer\r\n\tThe user wants " +
                    "to be able to get discount for order, when the user has filled discount code", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("The user fills correct discount code")]
        [NUnit.Framework.CategoryAttribute("positive")]
        [NUnit.Framework.CategoryAttribute("fillcode")]
        [NUnit.Framework.TestCaseAttribute("special35", "35", null)]
        [NUnit.Framework.TestCaseAttribute("vip25", "25", null)]
        [NUnit.Framework.TestCaseAttribute("holiday20", "20", null)]
        [NUnit.Framework.TestCaseAttribute("SARAB", "5", null)]
        [NUnit.Framework.TestCaseAttribute("NOV", "5", null)]
        [NUnit.Framework.TestCaseAttribute("kelina15", "15", null)]
        public virtual void TheUserFillsCorrectDiscountCode(string discountCode, string discountPercent, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "positive",
                    "fillcode"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user fills correct discount code", @__tags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
    testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
    testRunner.And("The user is on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
    testRunner.When(string.Format("The user fills field for discount code with correct data as {0}", discountCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.And("The user clicks the button Check", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
    testRunner.Then(string.Format("The user gets discount for his order as {0}", discountPercent), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user is redirected to checkout page with correct discount code")]
        [NUnit.Framework.CategoryAttribute("redirect")]
        [NUnit.Framework.CategoryAttribute("positive")]
        [NUnit.Framework.TestCaseAttribute("kendra35", "35", null)]
        [NUnit.Framework.TestCaseAttribute("vip25", "25", null)]
        public virtual void TheUserIsRedirectedToCheckoutPageWithCorrectDiscountCode(string discountCode, string discountPercent, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "redirect",
                    "positive"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user is redirected to checkout page with correct discount code", @__tags);
#line 23
this.ScenarioSetup(scenarioInfo);
#line 24
    testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
    testRunner.And("The user is on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
    testRunner.And(string.Format("The user fills  field for discount code with correct data  as {0}", discountCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.And("The user clicks the button Check", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
    testRunner.When("The user clicks the button Next for redirecting to the checkout page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("The user is redirected to the checkout page,", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
 testRunner.And(string.Format("The field for discount code should get value as {0}", discountPercent), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user fills incorrect discount code")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.CategoryAttribute("fillcode")]
        [NUnit.Framework.TestCaseAttribute("kendra3545", null)]
        [NUnit.Framework.TestCaseAttribute("000vip", null)]
        [NUnit.Framework.TestCaseAttribute("kimcoup", null)]
        [NUnit.Framework.TestCaseAttribute("Bles", null)]
        [NUnit.Framework.TestCaseAttribute("test", null)]
        [NUnit.Framework.TestCaseAttribute("15", null)]
        [NUnit.Framework.TestCaseAttribute("dawn2008", null)]
        public virtual void TheUserFillsIncorrectDiscountCode(string discountCode, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "negative",
                    "fillcode"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user fills incorrect discount code", @__tags);
#line 37
this.ScenarioSetup(scenarioInfo);
#line 38
    testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 39
    testRunner.And("The user is on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
    testRunner.When(string.Format("The user fills  field for discount code with incorrect data as {0}", discountCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.And("The user clicks the button Check", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
    testRunner.Then("The user doesn`t get discount for his order, field for discount code should get a" +
                    " red border.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user is blocked to checkout page with incorrect discount code")]
        [NUnit.Framework.CategoryAttribute("redirect")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.TestCaseAttribute("kendra3545", null)]
        [NUnit.Framework.TestCaseAttribute("000vip", null)]
        [NUnit.Framework.TestCaseAttribute("kimcoup", null)]
        [NUnit.Framework.TestCaseAttribute("Bles", null)]
        [NUnit.Framework.TestCaseAttribute("test", null)]
        [NUnit.Framework.TestCaseAttribute("15", null)]
        [NUnit.Framework.TestCaseAttribute("dawn2008", null)]
        public virtual void TheUserIsBlockedToCheckoutPageWithIncorrectDiscountCode(string discountCode, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "redirect",
                    "negative"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user is blocked to checkout page with incorrect discount code", @__tags);
#line 54
this.ScenarioSetup(scenarioInfo);
#line 55
    testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 56
    testRunner.And("The user is on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
    testRunner.And(string.Format("The user fills  field for discount code with incorrect data  as {0}", discountCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.And("The user clicks the button Check", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
    testRunner.When("The user clicks the button Next for redirecting to the checkout page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
 testRunner.Then("The user doesn`t redirected to the checkout page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 61
 testRunner.And("The field for discount code should get a red border", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check discount percent for order")]
        [NUnit.Framework.CategoryAttribute("positive")]
        [NUnit.Framework.CategoryAttribute("discountpercent")]
        [NUnit.Framework.TestCaseAttribute("kendra35", "35", null)]
        [NUnit.Framework.TestCaseAttribute("vip25", "25", null)]
        [NUnit.Framework.TestCaseAttribute("holiday20", "20", null)]
        [NUnit.Framework.TestCaseAttribute("SARAB", "5", null)]
        public virtual void CheckDiscountPercentForOrder(string discountCode, string discountPercent, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "positive",
                    "discountpercent"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check discount percent for order", @__tags);
#line 73
this.ScenarioSetup(scenarioInfo);
#line 74
    testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 75
    testRunner.And("The user is on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
    testRunner.When(string.Format("The user fills the field for discount code with correct data as {0}", discountCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.And("The user clicks the button Check", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
    testRunner.Then(string.Format("The user gets right discount percent for his order as {0}", discountPercent), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Expired  start date for discount code")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.CategoryAttribute("expiredstart`code")]
        [NUnit.Framework.TestCaseAttribute("kimcoup30", null)]
        [NUnit.Framework.TestCaseAttribute("todayonly15", null)]
        [NUnit.Framework.TestCaseAttribute("dawn20", null)]
        public virtual void ExpiredStartDateForDiscountCode(string discountCode, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "negative",
                    "expiredstart`code"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Expired  start date for discount code", @__tags);
#line 87
this.ScenarioSetup(scenarioInfo);
#line 88
    testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 89
    testRunner.And("The user is on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
    testRunner.When(string.Format("The user fills field for discount code with expired start date as {0}", discountCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 91
 testRunner.And("The user clicks the button Check", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.Then("The user doesn`t redirected to the checkout page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 93
 testRunner.And("The field for discount code should get a red border", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Expired  end date for discount code")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.CategoryAttribute("expiredendcode")]
        [NUnit.Framework.TestCaseAttribute("Blessings35", null)]
        [NUnit.Framework.TestCaseAttribute("emmy15", null)]
        [NUnit.Framework.TestCaseAttribute("special15", null)]
        public virtual void ExpiredEndDateForDiscountCode(string discountCode, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "negative",
                    "expiredendcode"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Expired  end date for discount code", @__tags);
#line 101
this.ScenarioSetup(scenarioInfo);
#line 102
    testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 103
    testRunner.And("The user is on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
    testRunner.When(string.Format("The user fills field for discount code with expired end date as {0}", discountCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 105
 testRunner.And("The user clicks the button Check", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
 testRunner.Then("The user doesn`t redirected to the checkout page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 107
 testRunner.And("The field for discount code should get a red border", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
