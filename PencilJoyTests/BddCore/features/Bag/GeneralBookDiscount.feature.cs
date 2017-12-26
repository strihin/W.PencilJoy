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
    [NUnit.Framework.DescriptionAttribute("Verify discount for next book")]
    public partial class VerifyDiscountForNextBookFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GeneralBookDiscount.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Verify discount for next book", "\tIn order to buy next book\r\n\tAs a customer\r\n\tThe user wants to be able to buy boo" +
                    "k with general discount for next book", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("The user buys a book without general discount")]
        [NUnit.Framework.CategoryAttribute("positive")]
        [NUnit.Framework.CategoryAttribute("generaldiscount")]
        [NUnit.Framework.TestCaseAttribute("1", "0", null)]
        public virtual void TheUserBuysABookWithoutGeneralDiscount(string numberBook, string percent, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "positive",
                    "generaldiscount"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user buys a book without general discount", @__tags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
    testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
    testRunner.And("The user is on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
    testRunner.When("The user has 1 book in the bag", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
    testRunner.Then(string.Format("The user has correct discount percent for each book as {0}, {1}", numberBook, percent), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user buys 2 books with general discount")]
        [NUnit.Framework.CategoryAttribute("positive")]
        [NUnit.Framework.CategoryAttribute("generaldiscount")]
        [NUnit.Framework.TestCaseAttribute("1", "0", null)]
        [NUnit.Framework.TestCaseAttribute("2", "10", null)]
        public virtual void TheUserBuys2BooksWithGeneralDiscount(string numberBook, string percent, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "positive",
                    "generaldiscount"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user buys 2 books with general discount", @__tags);
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
    testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
    testRunner.And("The user is on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
    testRunner.When("The user has 2 books in the bag", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
    testRunner.Then(string.Format("The user has correct discount percent for each book as {0}, {1}", numberBook, percent), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user buys 3 books with general discount")]
        [NUnit.Framework.CategoryAttribute("positive")]
        [NUnit.Framework.CategoryAttribute("generaldiscount")]
        [NUnit.Framework.TestCaseAttribute("1", "0", null)]
        [NUnit.Framework.TestCaseAttribute("2", "10", null)]
        [NUnit.Framework.TestCaseAttribute("3", "15", null)]
        public virtual void TheUserBuys3BooksWithGeneralDiscount(string numberBook, string percent, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "positive",
                    "generaldiscount"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user buys 3 books with general discount", @__tags);
#line 28
this.ScenarioSetup(scenarioInfo);
#line 29
    testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 30
    testRunner.And("The user is on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
    testRunner.When("The user has 3 books in the bag", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
    testRunner.Then(string.Format("The user has correct discount percent for each book as {0}, {1}", numberBook, percent), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user buys 4 books with general discount")]
        [NUnit.Framework.CategoryAttribute("positive")]
        [NUnit.Framework.CategoryAttribute("generaldiscount")]
        [NUnit.Framework.TestCaseAttribute("1", "0", null)]
        [NUnit.Framework.TestCaseAttribute("2", "10", null)]
        [NUnit.Framework.TestCaseAttribute("3", "15", null)]
        [NUnit.Framework.TestCaseAttribute("4", "20", null)]
        public virtual void TheUserBuys4BooksWithGeneralDiscount(string numberBook, string percent, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "positive",
                    "generaldiscount"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user buys 4 books with general discount", @__tags);
#line 40
this.ScenarioSetup(scenarioInfo);
#line 41
    testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 42
    testRunner.And("The user is on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
    testRunner.When("The user has 4 books in the bag", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
    testRunner.Then(string.Format("The user has correct discount percent for each book as {0}, {1}", numberBook, percent), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user buys 5 books with general discount")]
        [NUnit.Framework.CategoryAttribute("positive")]
        [NUnit.Framework.CategoryAttribute("generaldiscount")]
        [NUnit.Framework.TestCaseAttribute("1", "0", null)]
        [NUnit.Framework.TestCaseAttribute("2", "10", null)]
        [NUnit.Framework.TestCaseAttribute("3", "15", null)]
        [NUnit.Framework.TestCaseAttribute("4", "20", null)]
        [NUnit.Framework.TestCaseAttribute("5", "25", null)]
        public virtual void TheUserBuys5BooksWithGeneralDiscount(string numberBook, string percent, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "positive",
                    "generaldiscount"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user buys 5 books with general discount", @__tags);
#line 53
this.ScenarioSetup(scenarioInfo);
#line 54
    testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 55
    testRunner.And("The user is on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
    testRunner.When("The user has 5 books in the bag", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
    testRunner.Then(string.Format("The user has correct discount percent for each book as {0}, {1}", numberBook, percent), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user buys 6 books with general discount")]
        [NUnit.Framework.CategoryAttribute("positive")]
        [NUnit.Framework.CategoryAttribute("generaldiscount")]
        [NUnit.Framework.TestCaseAttribute("1", "0", null)]
        [NUnit.Framework.TestCaseAttribute("2", "10", null)]
        [NUnit.Framework.TestCaseAttribute("3", "15", null)]
        [NUnit.Framework.TestCaseAttribute("4", "20", null)]
        [NUnit.Framework.TestCaseAttribute("5", "25", null)]
        [NUnit.Framework.TestCaseAttribute("6", "25", null)]
        public virtual void TheUserBuys6BooksWithGeneralDiscount(string numberBook, string percent, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "positive",
                    "generaldiscount"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user buys 6 books with general discount", @__tags);
#line 67
this.ScenarioSetup(scenarioInfo);
#line 68
    testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 69
    testRunner.And("The user is on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
    testRunner.When("The user has 6 books in the bag", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
    testRunner.Then(string.Format("The user has correct discount percent for each book as {0}, {1}", numberBook, percent), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user buys 12 books with general discount")]
        [NUnit.Framework.CategoryAttribute("positive")]
        [NUnit.Framework.CategoryAttribute("generaldiscount")]
        [NUnit.Framework.TestCaseAttribute("1", "0", null)]
        [NUnit.Framework.TestCaseAttribute("2", "10", null)]
        [NUnit.Framework.TestCaseAttribute("3", "15", null)]
        [NUnit.Framework.TestCaseAttribute("4", "20", null)]
        [NUnit.Framework.TestCaseAttribute("5", "25", null)]
        [NUnit.Framework.TestCaseAttribute("6", "25", null)]
        [NUnit.Framework.TestCaseAttribute("7", "25", null)]
        [NUnit.Framework.TestCaseAttribute("8", "25", null)]
        [NUnit.Framework.TestCaseAttribute("9", "25", null)]
        [NUnit.Framework.TestCaseAttribute("10", "25", null)]
        [NUnit.Framework.TestCaseAttribute("11", "25", null)]
        [NUnit.Framework.TestCaseAttribute("12", "25", null)]
        public virtual void TheUserBuys12BooksWithGeneralDiscount(string numberBook, string percent, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "positive",
                    "generaldiscount"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user buys 12 books with general discount", @__tags);
#line 82
this.ScenarioSetup(scenarioInfo);
#line 83
    testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 84
    testRunner.And("The user is on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
    testRunner.When("The user has 12 books in the bag", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
    testRunner.Then(string.Format("The user has correct discount percent for each book as {0}, {1}", numberBook, percent), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
