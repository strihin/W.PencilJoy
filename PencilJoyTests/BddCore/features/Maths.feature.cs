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
namespace PencilJoyTests.BddCore.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Equal price and discount value on different steps of order")]
    public partial class EqualPriceAndDiscountValueOnDifferentStepsOfOrderFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Maths.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Equal price and discount value on different steps of order", "\tIn order to compare value on different steps of order\r\n\tAs a customer\r\n\tThe user" +
                    " wants to be able to edit currency for order", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("The user compares price and currency for a book on the preview page and on the ba" +
            "g page")]
        [NUnit.Framework.CategoryAttribute("comparePriceForABook")]
        [NUnit.Framework.CategoryAttribute("previewPage")]
        [NUnit.Framework.CategoryAttribute("bagPage")]
        public virtual void TheUserComparesPriceAndCurrencyForABookOnThePreviewPageAndOnTheBagPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user compares price and currency for a book on the preview page and on the ba" +
                    "g page", new string[] {
                        "comparePriceForABook",
                        "previewPage",
                        "bagPage"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And("The user is on the preview page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("The user gets price and currency for a book from the button  Order on the preview" +
                    " page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("The user clicks the button  Order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("The user clicks the button Next on the message page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.When("The user gets price and currency  for the first book on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.Then("The price and currency for a book on the preview page and on the bag page should " +
                    "be equal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user compares price and currency for a book on the bag page and on the checko" +
            "ut page")]
        [NUnit.Framework.CategoryAttribute("comparePriceForABook")]
        [NUnit.Framework.CategoryAttribute("bagPage")]
        [NUnit.Framework.CategoryAttribute("checkoutPage")]
        public virtual void TheUserComparesPriceAndCurrencyForABookOnTheBagPageAndOnTheCheckoutPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user compares price and currency for a book on the bag page and on the checko" +
                    "ut page", new string[] {
                        "comparePriceForABook",
                        "bagPage",
                        "checkoutPage"});
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
 testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
 testRunner.And("The user is on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And("The user gets price and currency for the first book on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.And("The user clicks the button Next", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.When("The user gets  price and currency for the first book on the checkout page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then("The price and currency for a book on the bag page and  on the checkout page shoul" +
                    "d be equal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user compares totalprice and currency for order on the bag page and on the ch" +
            "eckout page")]
        [NUnit.Framework.CategoryAttribute("compareTotalPrice")]
        [NUnit.Framework.CategoryAttribute("bagPage")]
        [NUnit.Framework.CategoryAttribute("checkoutPage")]
        public virtual void TheUserComparesTotalpriceAndCurrencyForOrderOnTheBagPageAndOnTheCheckoutPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user compares totalprice and currency for order on the bag page and on the ch" +
                    "eckout page", new string[] {
                        "compareTotalPrice",
                        "bagPage",
                        "checkoutPage"});
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
 testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
 testRunner.And("The user is on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("The user gets price and currency for the totalprice on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("The user clicks the button Next", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.When("The user gets  price and currency for the totalprice on the checkout page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.Then("The price and currency for the totalprice on the bag page and on the checkout pag" +
                    "e should be equal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user compares totalprice and currency for order with discount code on the bag" +
            " page and on the checkout page")]
        [NUnit.Framework.CategoryAttribute("compareTotalPriceWithDiscount")]
        [NUnit.Framework.CategoryAttribute("bagPage")]
        [NUnit.Framework.CategoryAttribute("checkoutPage")]
        public virtual void TheUserComparesTotalpriceAndCurrencyForOrderWithDiscountCodeOnTheBagPageAndOnTheCheckoutPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user compares totalprice and currency for order with discount code on the bag" +
                    " page and on the checkout page", new string[] {
                        "compareTotalPriceWithDiscount",
                        "bagPage",
                        "checkoutPage"});
#line 35
this.ScenarioSetup(scenarioInfo);
#line 36
 testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 37
 testRunner.And("The user is on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("The user enters correct discount code", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("The user gets price and currency for the totalprice on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And("The user clicks the button Next", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.When("The user gets  price and currency for the totalprice on the checkout page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
 testRunner.Then("The price and currency for the totalprice on the bag page and on the checkout pag" +
                    "e should be equal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user compares discount percent and name for order on the bag page and on the " +
            "checkout page")]
        [NUnit.Framework.CategoryAttribute("compareDiscountPercent")]
        [NUnit.Framework.CategoryAttribute("bagPage")]
        [NUnit.Framework.CategoryAttribute("checkoutPage")]
        [NUnit.Framework.TestCaseAttribute("special35", "35", null)]
        [NUnit.Framework.TestCaseAttribute("vip25", "25", null)]
        public virtual void TheUserComparesDiscountPercentAndNameForOrderOnTheBagPageAndOnTheCheckoutPage(string discountCode, string discountPercent, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "compareDiscountPercent",
                    "bagPage",
                    "checkoutPage"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user compares discount percent and name for order on the bag page and on the " +
                    "checkout page", @__tags);
#line 45
this.ScenarioSetup(scenarioInfo);
#line 46
 testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 47
 testRunner.And("The user is on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.And(string.Format("The user enters correct discount code as {0}", discountCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.And(string.Format("The user gets discount percent and name for order on the bag page as {0}", discountPercent), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.And("The user clicks the button Next", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.When(string.Format("The user gets discount percent and name for order on the checkout page as {0}  {1" +
                        "}", discountCode, discountPercent), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
 testRunner.Then("The discount percent and name for order should be equal on the bag page and on th" +
                    "e checkout page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user verifies price for booklist on the bag page")]
        [NUnit.Framework.CategoryAttribute("verifyPriceBookList")]
        [NUnit.Framework.CategoryAttribute("bagPage")]
        public virtual void TheUserVerifiesPriceForBooklistOnTheBagPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user verifies price for booklist on the bag page", new string[] {
                        "verifyPriceBookList",
                        "bagPage"});
#line 59
this.ScenarioSetup(scenarioInfo);
#line 60
 testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 61
 testRunner.And("The user is on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.When("The user adds few books in the bag", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
 testRunner.Then("The price for every book should be equal counted values", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user compares price for booklist on the bag page and on the checkout page")]
        [NUnit.Framework.CategoryAttribute("comparePriceBookList")]
        [NUnit.Framework.CategoryAttribute("bagPage")]
        [NUnit.Framework.CategoryAttribute("checkoutPage")]
        public virtual void TheUserComparesPriceForBooklistOnTheBagPageAndOnTheCheckoutPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user compares price for booklist on the bag page and on the checkout page", new string[] {
                        "comparePriceBookList",
                        "bagPage",
                        "checkoutPage"});
#line 66
this.ScenarioSetup(scenarioInfo);
#line 67
 testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 68
 testRunner.And("The user is on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.And("The user adds few books in the bag", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.And("The user clicks the button Next", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.When("The user gets price for booklist on the checkout page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
 testRunner.Then("The price for booklist should be equal on the bag page and on the checkout page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user compares currency for totalprice on the bag page and on the checkout pag" +
            "e")]
        [NUnit.Framework.CategoryAttribute("compareCurrency")]
        [NUnit.Framework.CategoryAttribute("bagPage")]
        [NUnit.Framework.CategoryAttribute("checkoutPage")]
        [NUnit.Framework.CategoryAttribute("totalPrice")]
        public virtual void TheUserComparesCurrencyForTotalpriceOnTheBagPageAndOnTheCheckoutPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user compares currency for totalprice on the bag page and on the checkout pag" +
                    "e", new string[] {
                        "compareCurrency",
                        "bagPage",
                        "checkoutPage",
                        "totalPrice"});
#line 75
this.ScenarioSetup(scenarioInfo);
#line 76
 testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 77
 testRunner.And("The user is on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.And("The user adds few books in the bag", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And("The user gets currency from totalprice", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.And("The user clicks the button Next", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.When("The user gets currency for totalprice on the checkout page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 82
 testRunner.Then("The currency for totalprice should be equal on the bag page and on the checkout p" +
                    "age", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user compares price for the first book using different currency")]
        [NUnit.Framework.CategoryAttribute("comparePriceWithDifferentCurrency")]
        [NUnit.Framework.CategoryAttribute("bagPage")]
        [NUnit.Framework.TestCaseAttribute("USD", "29.99", null)]
        [NUnit.Framework.TestCaseAttribute("GBP", "19.99", null)]
        [NUnit.Framework.TestCaseAttribute("EUR", "26.99", null)]
        [NUnit.Framework.TestCaseAttribute("JPY", "3000.00", null)]
        [NUnit.Framework.TestCaseAttribute("AUD", "39.99", null)]
        [NUnit.Framework.TestCaseAttribute("CHF", "29.99", null)]
        [NUnit.Framework.TestCaseAttribute("CAD", "38.99", null)]
        [NUnit.Framework.TestCaseAttribute("SEK", "249.99", null)]
        [NUnit.Framework.TestCaseAttribute("NZD", "39.99", null)]
        public virtual void TheUserComparesPriceForTheFirstBookUsingDifferentCurrency(string currency, string currencyValue, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "comparePriceWithDifferentCurrency",
                    "bagPage"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user compares price for the first book using different currency", @__tags);
#line 85
this.ScenarioSetup(scenarioInfo);
#line 86
 testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 87
 testRunner.And("The user is on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
 testRunner.And("The user adds few books in the bag", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.When(string.Format("The user changes currency for order as {0}", currency), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 90
 testRunner.And("The user gets price for the first book", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.Then(string.Format("The price for the first book with  should be equal as {0}", currencyValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Checking price for order after removing a book")]
        [NUnit.Framework.CategoryAttribute("positive")]
        [NUnit.Framework.CategoryAttribute("priceorder")]
        public virtual void CheckingPriceForOrderAfterRemovingABook()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Checking price for order after removing a book", new string[] {
                        "positive",
                        "priceorder"});
#line 105
this.ScenarioSetup(scenarioInfo);
#line 106
    testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 107
    testRunner.And("The user is on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
    testRunner.When("The user clicks button Ok on the popup notification for removing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 109
    testRunner.Then("The price for the order should be subtracted price for removing book.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Compare price books on bag page and checkout page")]
        [NUnit.Framework.CategoryAttribute("positive")]
        [NUnit.Framework.CategoryAttribute("generaldiscount")]
        public virtual void ComparePriceBooksOnBagPageAndCheckoutPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compare price books on bag page and checkout page", new string[] {
                        "positive",
                        "generaldiscount"});
#line 112
this.ScenarioSetup(scenarioInfo);
#line 113
 testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 114
    testRunner.And("The user saves price book on the bag page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
    testRunner.When("The user is on the checkout page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 116
    testRunner.Then("The user compares price books on the bag page and the checkout page, they should " +
                    "be equal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
