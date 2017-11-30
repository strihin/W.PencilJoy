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
namespace PencilJoyTests.BddCore.Features.Checkout.Payment
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Add payment data to checkout page")]
    public partial class AddPaymentDataToCheckoutPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FillingCreditCard.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Add payment data to checkout page", "\tIn order to add payment data by credit card and paypal\r\n\tAs a customer\r\n\tThe use" +
                    "r wants to be able to fill payment data to the payment method ", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("The user fills fields for credit card with correct data")]
        [NUnit.Framework.CategoryAttribute("payment")]
        [NUnit.Framework.CategoryAttribute("positive")]
        [NUnit.Framework.TestCaseAttribute("4242424242424242", "392", "12", "2018", null)]
        [NUnit.Framework.TestCaseAttribute("4242424242424242", "451", "1", "2018", null)]
        [NUnit.Framework.TestCaseAttribute("4242424242424242", "392", "6", "2022", null)]
        public virtual void TheUserFillsFieldsForCreditCardWithCorrectData(string creditCardInput, string cardVerifacationValue, string selectMonth, string selectYear, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "payment",
                    "positive"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user fills fields for credit card with correct data", @__tags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
    testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
    testRunner.And("The user is on checkout page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "UsernameB",
                        "LastnameB",
                        "StreetB",
                        "CityB",
                        "ZipCodeB",
                        "PhoneB",
                        "NumberCountryB",
                        "RegionB"});
            table1.AddRow(new string[] {
                        "August",
                        "Accomb",
                        "8 Grasskamp Trail",
                        "Kuroiso",
                        "0093-7206",
                        "+81 (504) 678-7207",
                        "3",
                        "Cucutilla"});
#line 10
    testRunner.And("The user correct fills the fields for Billing Address  as <UsernameB> <LastnameB>" +
                    " <StreetB> <CityB>\t<ZipCodeB> <PhoneB> <NumberCountryB> <RegionB>", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "UsernameS",
                        "LastnameS",
                        "StreetS",
                        "CityS",
                        "ZipCodeS",
                        "PhoneS",
                        "NumberCountryS",
                        "RegionS"});
            table2.AddRow(new string[] {
                        "Grace",
                        "Chictto",
                        "115 Arizona Parkway",
                        "Langtang",
                        "36800-647",
                        "+234 (683) 231-9702",
                        "20",
                        "Gongju"});
#line 13
 testRunner.And("The user correct fills the fields for Shipping Address as <UsernameS> <LastnameS>" +
                    " <StreetS> <CityS>\t<ZipCodeS> <PhoneS> <NumberCountryS> <RegionS>", ((string)(null)), table2, "And ");
#line 16
    testRunner.And(string.Format("The user fills the fields for \'Credit Card\' tab with correct data  such as {0}\t{1" +
                        "} {2}\t{3}", creditCardInput, cardVerifacationValue, selectMonth, selectYear), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
    testRunner.When("The user clicks the button \'Place your order\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
    testRunner.Then("Page is redirected to successful page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user does not fill fields for credit card")]
        [NUnit.Framework.CategoryAttribute("payment")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.CategoryAttribute("emptyForm")]
        public virtual void TheUserDoesNotFillFieldsForCreditCard()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user does not fill fields for credit card", new string[] {
                        "payment",
                        "negative",
                        "emptyForm"});
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
    testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
    testRunner.And("The user is on checkout page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "UsernameB",
                        "LastnameB",
                        "StreetB",
                        "CityB",
                        "ZipCodeB",
                        "PhoneB",
                        "NumberCountryB",
                        "RegionB"});
            table3.AddRow(new string[] {
                        "August",
                        "Accomb",
                        "8 Grasskamp Trail",
                        "Kuroiso",
                        "0093-7206",
                        "+81 (504) 678-7207",
                        "3",
                        "Cucutilla"});
#line 29
    testRunner.And("The user correct fills the fields for Billing Address  as <UsernameB> <LastnameB>" +
                    " <StreetB> <CityB>\t<ZipCodeB> <PhoneB> <NumberCountryB> <RegionB>", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "UsernameS",
                        "LastnameS",
                        "StreetS",
                        "CityS",
                        "ZipCodeS",
                        "PhoneS",
                        "NumberCountryS",
                        "RegionS"});
            table4.AddRow(new string[] {
                        "Grace",
                        "Chictto",
                        "115 Arizona Parkway",
                        "Langtang",
                        "36800-647",
                        "+234 (683) 231-9702",
                        "20",
                        "Gongju"});
#line 32
 testRunner.And("The user correct fills the fields for Shipping Address as <UsernameS> <LastnameS>" +
                    " <StreetS> <CityS>\t<ZipCodeS> <PhoneS> <NumberCountryS> <RegionS>", ((string)(null)), table4, "And ");
#line 35
    testRunner.And("The user chooses the tab \'Credit Card\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.When("The user left the fields as empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
    testRunner.Then("Page doessn`t redirected to successful page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
 testRunner.And("It should be shown message \"Could not find payment information.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user fills the textbox \"Card verification value\" with incorrect data")]
        [NUnit.Framework.CategoryAttribute("payment")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.CategoryAttribute("vercode")]
        [NUnit.Framework.TestCaseAttribute("4242424242424242", "08968987689", "12", "2018", null)]
        [NUnit.Framework.TestCaseAttribute("4242424242424242", "2", "1", "2018", null)]
        [NUnit.Framework.TestCaseAttribute("4242424242424242", "", "6", "2022", null)]
        [NUnit.Framework.TestCaseAttribute("4242424242424242", "string", "4", "2020", null)]
        [NUnit.Framework.TestCaseAttribute("4242424242424242", "78u", "3", "2019", null)]
        public virtual void TheUserFillsTheTextboxCardVerificationValueWithIncorrectData(string creditCardInput, string cardVerifacationValue, string selectMonth, string selectYear, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "payment",
                    "negative",
                    "vercode"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user fills the textbox \"Card verification value\" with incorrect data", @__tags);
#line 41
this.ScenarioSetup(scenarioInfo);
#line 42
    testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 43
    testRunner.And("The user is on checkout page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "UsernameB",
                        "LastnameB",
                        "StreetB",
                        "CityB",
                        "ZipCodeB",
                        "PhoneB",
                        "NumberCountryB",
                        "RegionB"});
            table5.AddRow(new string[] {
                        "August",
                        "Accomb",
                        "8 Grasskamp Trail",
                        "Kuroiso",
                        "0093-7206",
                        "+81 (504) 678-7207",
                        "3",
                        "Cucutilla"});
#line 44
    testRunner.And("The user correct fills the fields for Billing Address  as <UsernameB> <LastnameB>" +
                    " <StreetB> <CityB>\t<ZipCodeB> <PhoneB> <NumberCountryB> <RegionB>", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "UsernameS",
                        "LastnameS",
                        "StreetS",
                        "CityS",
                        "ZipCodeS",
                        "PhoneS",
                        "NumberCountryS",
                        "RegionS"});
            table6.AddRow(new string[] {
                        "Grace",
                        "Chictto",
                        "115 Arizona Parkway",
                        "Langtang",
                        "36800-647",
                        "+234 (683) 231-9702",
                        "20",
                        "Gongju"});
#line 47
 testRunner.And("The user correct fills the fields for Shipping Address as <UsernameS> <LastnameS>" +
                    " <StreetS> <CityS>\t<ZipCodeS> <PhoneS> <NumberCountryS> <RegionS>", ((string)(null)), table6, "And ");
#line 50
    testRunner.And("The user chooses the tab \'Credit Card\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
    testRunner.When(string.Format("The user fills the fields for \'Credit Card\' tab with correct data and the card ve" +
                        "rification value with incorrect data as {0}\t{1} {2}\t{3}", creditCardInput, cardVerifacationValue, selectMonth, selectYear), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
    testRunner.Then("Page doesn`t redirected to successful page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 53
 testRunner.And("It should be shown message \"Could not find payment information.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user fills fields for credit card with expired date")]
        [NUnit.Framework.CategoryAttribute("payment")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.CategoryAttribute("expiredDate")]
        [NUnit.Framework.TestCaseAttribute("4242424242424242", "392", "1", "2017", null)]
        [NUnit.Framework.TestCaseAttribute("4242424242424242", "451", "12", "2016", null)]
        [NUnit.Framework.TestCaseAttribute("4242424242424242", "392", "11", "2017", null)]
        public virtual void TheUserFillsFieldsForCreditCardWithExpiredDate(string creditCardInput, string cardVerifacationValue, string selectMonth, string selectYear, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "payment",
                    "negative",
                    "expiredDate"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user fills fields for credit card with expired date", @__tags);
#line 63
this.ScenarioSetup(scenarioInfo);
#line 64
    testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 65
    testRunner.And("The user is on checkout page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "UsernameB",
                        "LastnameB",
                        "StreetB",
                        "CityB",
                        "ZipCodeB",
                        "PhoneB",
                        "NumberCountryB",
                        "RegionB"});
            table7.AddRow(new string[] {
                        "August",
                        "Accomb",
                        "8 Grasskamp Trail",
                        "Kuroiso",
                        "0093-7206",
                        "+81 (504) 678-7207",
                        "3",
                        "Cucutilla"});
#line 66
    testRunner.And("The user correct fills the fields for Billing Address  as <UsernameB> <LastnameB>" +
                    " <StreetB> <CityB>\t<ZipCodeB> <PhoneB> <NumberCountryB> <RegionB>", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "UsernameS",
                        "LastnameS",
                        "StreetS",
                        "CityS",
                        "ZipCodeS",
                        "PhoneS",
                        "NumberCountryS",
                        "RegionS"});
            table8.AddRow(new string[] {
                        "Grace",
                        "Chictto",
                        "115 Arizona Parkway",
                        "Langtang",
                        "36800-647",
                        "+234 (683) 231-9702",
                        "20",
                        "Gongju"});
#line 69
 testRunner.And("The user correct fills the fields for Shipping Address as <UsernameS> <LastnameS>" +
                    " <StreetS> <CityS>\t<ZipCodeS> <PhoneS> <NumberCountryS> <RegionS>", ((string)(null)), table8, "And ");
#line 72
    testRunner.And("The user chooses the tab \'Credit Card\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
    testRunner.When(string.Format("The user fills the fields for \'Credit Card\' tab with correct data besides the exp" +
                        "iration date as {0} {1} {2}\t{3}", creditCardInput, cardVerifacationValue, selectMonth, selectYear), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
    testRunner.And("The user clicks the button \"Place your order\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
    testRunner.Then("Page doesn`t redirected to successful page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 76
 testRunner.And("It should be shown message \"Could not find payment information.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user fills fields for credit card with incorrect card number")]
        [NUnit.Framework.CategoryAttribute("payment")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.CategoryAttribute("cardNumber")]
        [NUnit.Framework.TestCaseAttribute("1010010100001010", "392", "12", "2018", null)]
        [NUnit.Framework.TestCaseAttribute("0", "451", "1", "2018", null)]
        [NUnit.Framework.TestCaseAttribute("24242424242424278", "392", "6", "2022", null)]
        [NUnit.Framework.TestCaseAttribute("stringvalue", "392", "12", "2018", null)]
        [NUnit.Framework.TestCaseAttribute("424242stringvalue", "451", "1", "2018", null)]
        [NUnit.Framework.TestCaseAttribute("0978578646587689", "392", "6", "2022", null)]
        public virtual void TheUserFillsFieldsForCreditCardWithIncorrectCardNumber(string creditCardInput, string cardVerifacationValue, string selectMonth, string selectYear, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "payment",
                    "negative",
                    "cardNumber"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user fills fields for credit card with incorrect card number", @__tags);
#line 84
this.ScenarioSetup(scenarioInfo);
#line 85
    testRunner.Given("The user is a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 86
    testRunner.And("The user is on checkout page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "UsernameB",
                        "LastnameB",
                        "StreetB",
                        "CityB",
                        "ZipCodeB",
                        "PhoneB",
                        "NumberCountryB",
                        "RegionB"});
            table9.AddRow(new string[] {
                        "August",
                        "Accomb",
                        "8 Grasskamp Trail",
                        "Kuroiso",
                        "0093-7206",
                        "+81 (504) 678-7207",
                        "3",
                        "Cucutilla"});
#line 87
    testRunner.And("The user correct fills the fields for Billing Address  as <UsernameB> <LastnameB>" +
                    " <StreetB> <CityB>\t<ZipCodeB> <PhoneB> <NumberCountryB> <RegionB>", ((string)(null)), table9, "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "UsernameS",
                        "LastnameS",
                        "StreetS",
                        "CityS",
                        "ZipCodeS",
                        "PhoneS",
                        "NumberCountryS",
                        "RegionS"});
            table10.AddRow(new string[] {
                        "Grace",
                        "Chictto",
                        "115 Arizona Parkway",
                        "Langtang",
                        "36800-647",
                        "+234 (683) 231-9702",
                        "20",
                        "Gongju"});
#line 90
 testRunner.And("The user correct fills the fields for Shipping Address as <UsernameS> <LastnameS>" +
                    " <StreetS> <CityS>\t<ZipCodeS> <PhoneS> <NumberCountryS> <RegionS>", ((string)(null)), table10, "And ");
#line 93
    testRunner.And("The user chooses the tab \'Credit Card\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
    testRunner.When(string.Format("The user fills the fields for \'Credit Card\' tab with correct data besides the car" +
                        "d number as {0} {1} {2}\t{3}", creditCardInput, cardVerifacationValue, selectMonth, selectYear), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 96
    testRunner.When("The user fills the card number with incorrect data such as \"1010 0101 0000 1010\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 97
    testRunner.And("The user clicks the button \"Place your order\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
    testRunner.Then("Page doesn`t redirected to successful page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 99
 testRunner.And("It should be shown message \"Could not find payment information.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
