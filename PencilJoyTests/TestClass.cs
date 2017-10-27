using NUnit.Framework;
using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using PencilJoyTests.ReportCore;
using PencilJoyTests.Data;
using PencilJoyTests.Math;
using PencilJoyTests.Pages;
using RelevantCodes.ExtentReports;

namespace PencilJoyTests
{
    [TestFixture]
    public class TestClass :  ExtentScreenshoter
    {

        private IWebDriver _webDriver;
        private WebDriverWait _waitDriver;
        private ExtentTest _test;
  
        [SetUp]
        public void InitializeBrowser()
        {
            _webDriver = new ChromeDriver();
        //  _webDriver = new FirefoxDriver();
        //  _webDriver.Manage().Window.Maximize();
            _waitDriver = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(11));
            _webDriver.Navigate().GoToUrl("http://penciljoy.altsolution.ua/");
            FullAdminData.LoadJson();
        }
 
         [Test]
        public void RemindMeLater()
        {
             PreviewMath previewMath = new PreviewMath();
             BagMath bagMath = new BagMath();
             CheckoutMath checkoutMath = new CheckoutMath(bagMath);
            _test = extent.StartTest("PayPal", "Payment by paypal. Page`s loaded long term");

            //Data initialization
            CreateBookData createBookData = new CreateBookData();
            CreateBookData editBookData = new CreateBookData();
            MessageAndIdentificationData messageData = new MessageAndIdentificationData();
            BagPageData bagPageData = new BagPageData("vip25", "USD");
            CheckoutAddressData checkoutShippingData = new CheckoutAddressData();
            CheckoutAddressData checkOutBillingData = new CheckoutAddressData();
            CheckoutPaymentData checkoutPaymentData = new CheckoutPaymentData();

            PaypalPaymentData paypalPaymentData = new PaypalPaymentData("maxim-buyer-2@altsolution.net", "12345678");
            
            //Page Objects initialization
            CreateBookPage objCreateBookPage = new CreateBookPage(_waitDriver, createBookData);
            EditBookPage objeditBookPage = new EditBookPage(_waitDriver, editBookData);
            PreviewPage objPreviewPage = new PreviewPage(_waitDriver, previewMath);
            MessageAndIdentificationPage objMessagePage = new MessageAndIdentificationPage(_waitDriver, messageData);
            BagPage objBagPage = new BagPage(_waitDriver, bagMath, bagPageData);
            CheckoutShippingAddressPage objCheckoutShippingAddressPage = new CheckoutShippingAddressPage(_waitDriver, checkoutShippingData);
            CheckoutBillingAddressPage objCheckoutBillingAddressPage = new CheckoutBillingAddressPage(_waitDriver, checkOutBillingData);
            CheckoutPaymentPage objCheckoutPaymentPage = new CheckoutPaymentPage(_waitDriver, checkoutPaymentData, checkoutMath);
            PaypalPaymentPage objPaypalPaymentPage = new PaypalPaymentPage(_waitDriver, _webDriver);
            SuccessfulOrderPage successfulOrderPage = new SuccessfulOrderPage(_waitDriver);
           
            try
            {
                //Methods
                _test.Log(LogStatus.Pass, objCreateBookPage.LoginIntoBookData());
                _test.Log(LogStatus.Pass, objCreateBookPage.EntryLoginIntoBookData());
                _test.Log(LogStatus.Pass, objPreviewPage.EditCurrency());
                _test.Log(LogStatus.Pass, objPreviewPage.GetPreviewPageTitle());

                _test.Log(LogStatus.Pass, objMessagePage.EditMessage());
                _test.Log(LogStatus.Pass, objMessagePage.LoginNewCustomer());
                _test.Log(LogStatus.Pass, objMessagePage.NextStepToBag());

                _test.Log(LogStatus.Pass, objBagPage.ShopMoreBooks());
                _test.Log(LogStatus.Pass, objCreateBookPage.LoginIntoBookData());
                _test.Log(LogStatus.Pass, objCreateBookPage.EntryLoginIntoBookData());
                _test.Log(LogStatus.Pass, objPreviewPage.GetPreviewPageTitle());
                _test.Log(LogStatus.Pass, objMessagePage.NextStepToBag());

                objBagPage.CheckDiscount();

                _test.Log(LogStatus.Pass, objBagPage.ShopMoreBooks());
                _test.Log(LogStatus.Pass, objCreateBookPage.LoginIntoBookData());
                _test.Log(LogStatus.Pass, objCreateBookPage.EntryLoginIntoBookData());
                _test.Log(LogStatus.Pass, objPreviewPage.GetPreviewPageTitle());
                _test.Log(LogStatus.Pass, objMessagePage.NextStepToBag());
            
                _test.Log(LogStatus.Pass, objBagPage.RemoveBook(_webDriver));
                _test.Log(LogStatus.Pass, objBagPage.GetCheckoutPage());
                objCheckoutPaymentPage.GetMathPriceForCheckoutMath();

                objCheckoutPaymentPage.GetMathPriceForCheckoutMath();
                _test.Log(LogStatus.Pass, objCheckoutShippingAddressPage.LoginIntoShippingAddress());
                _test.Log(LogStatus.Pass, objCheckoutShippingAddressPage.BillToThisAddress());
                _test.Log(LogStatus.Pass, objCheckoutBillingAddressPage.LoginIntoBillingAddress());
             //   objCheckoutPaymentPage.GetPriceAndDiscountCode();
                objCheckoutPaymentPage.PaymentAddress();
            //    _test.Log(LogStatus.Pass, objPaypalPaymentPage.FillFields(paypalPaymentData));
                _test.Log(LogStatus.Pass, successfulOrderPage.GetOrderNumber());
                
                Assert.True(true, "Overall steps has been successful");
            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }
        }
        /*
        public void TestUsingPayPal2()
        {

            _test = extent.StartTest("PayPal without username", "No data for username");
            //Data initialization
            CreateBookData createBookData = new CreateBookData("UsernameXX", 4, 1, 1, 2);
            NewCustomerMessageData messageData = new NewCustomerMessageData("testname", "testmail@yahoo.com");
            CheckoutAddressData checkoutAddressData = new CheckoutAddressData("", "Userlastname", "Haharina ", "London", "101010", "+3890829027092");
            PaypalPaymentData paypalPaymentData = new PaypalPaymentData("maxim-buyer-2@altsolution.net", "12345678");

            //Page Objects initialization
            CreateBookPage objCreateBookPage = new CreateBookPage(_waitDriver, createBookData);
            PreviewPage objPreviewPage = new PreviewPage(_waitDriver);
            MessagePage objMessagePage = new MessagePage(_waitDriver);
            BagPage objBagPage = new BagPage(_waitDriver);
            CheckOutPage objCheckOutPage = new CheckOutPage(_waitDriver);
            //SuccessPage objSuccessPage = new SuccessPage(_waitDriver);
            PaypalPaymentPage objPaypalPaymentPage = new PaypalPaymentPage(_waitDriver, _webDriver);

            try
            {
                //Methods
                _test.Log(LogStatus.Pass, objCreateBookPage.LoginIntoBookData());
                _test.Log(LogStatus.Pass, objPreviewPage.GetPreviewPageTitle());
                _test.Log(LogStatus.Pass, objMessagePage.LoginNewCustomer(messageData));
                _test.Log(LogStatus.Pass, objBagPage.GetBagPageTitle());
                _test.Log(LogStatus.Pass, objCheckOutPage.LoginIntoShippingAddress(checkoutAddressData));
                _test.Log(LogStatus.Pass, objCheckOutPage.PaymentMethodPaypal());
                _test.Log(LogStatus.Pass, objPaypalPaymentPage.FillFields(paypalPaymentData));
                Assert.True(true, "Overall steps has been successful");
            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }

        }
        public void TestUsingPayPal3()
        {

            _test = extent.StartTest("PayPal without phone number", "Field number phone is empty at checkout page");
            //Data initialization
            CreateBookData createBookData = new CreateBookData("UsernameXX", 4, 1, 1, 2);
            NewCustomerMessageData messageData = new NewCustomerMessageData("testname", "@yahoo.com");
            CheckoutAddressData checkoutAddressData = new CheckoutAddressData("Username", "Userlastname", "Haharina ", "London", "101010", "");
            PaypalPaymentData paypalPaymentData = new PaypalPaymentData("maxim-buyer-2@altsolution.net", "12345678");

            //Page Objects initialization
            CreateBookPage objCreateBookPage = new CreateBookPage(_waitDriver, createBookData);
            PreviewPage objPreviewPage = new PreviewPage(_waitDriver);
            MessagePage objMessagePage = new MessagePage(_waitDriver);
            BagPage objBagPage = new BagPage(_waitDriver);
            CheckOutPage objCheckOutPage = new CheckOutPage(_waitDriver);
            //SuccessPage objSuccessPage = new SuccessPage(_waitDriver);
            PaypalPaymentPage objPaypalPaymentPage = new PaypalPaymentPage(_waitDriver, _webDriver);

            try
            {
                //Methods
                _test.Log(LogStatus.Pass, objCreateBookPage.LoginIntoBookData());
                _test.Log(LogStatus.Pass, objPreviewPage.GetPreviewPageTitle());
                _test.Log(LogStatus.Pass, objMessagePage.LoginNewCustomer(messageData));
                _test.Log(LogStatus.Pass, objBagPage.GetBagPageTitle());
                _test.Log(LogStatus.Pass, objCheckOutPage.LoginIntoShippingAddress(checkoutAddressData));
                _test.Log(LogStatus.Pass, objCheckOutPage.PaymentMethodPaypal());
                _test.Log(LogStatus.Pass, objPaypalPaymentPage.FillFields(paypalPaymentData));
                Assert.True(true, "Overall steps has been successful");
            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }
        }
        [Test]
        public void TestUsingAnotherCardPass()
        {
            _test = extent.StartTest("Correct card", "Case should be positive");

            //Data initialization
            CreateBookData createBookData = new CreateBookData("Username", 5, 31, 1, 5);
            NewCustomerMessageData messageData = new NewCustomerMessageData("testname2", "testmail@gmail.com");
            CheckoutAddressData checkoutAddressData = new CheckoutAddressData("Username2", "Userlastname2", "Hvardeisky ", "Moscow", "576576", "+3806215451564");
            CheckoutPaymentData checkoutPaymentData = new CheckoutPaymentData("424", "123", "12", "17");
            //Page Objects initialization
            CreateBookPage objCreateBookPage = new CreateBookPage(_waitDriver, createBookData);
            PreviewPage objPreviewPage = new PreviewPage(_waitDriver);
            MessagePage objMessagePage = new MessagePage(_waitDriver);
            BagPage objBagPage = new BagPage(_waitDriver);
            CheckOutPage objCheckOutPage = new CheckOutPage(_waitDriver, checkoutPaymentData);
            SuccessPage objSuccessPage = new SuccessPage(_waitDriver);

            try
            {
                //Methods
                _test.Log(LogStatus.Pass, objCreateBookPage.LoginIntoBookData());
                _test.Log(LogStatus.Pass, objPreviewPage.GetPreviewPageTitle());
                _test.Log(LogStatus.Pass, objMessagePage.LoginNewCustomer(messageData));
                _test.Log(LogStatus.Pass, objBagPage.GetBagPageTitle());
                _test.Log(LogStatus.Pass, objCheckOutPage.LoginIntoShippingAddress(checkoutAddressData));
                _test.Log(LogStatus.Pass, objCheckOutPage.PaymentAddress());
                _test.Log(LogStatus.Pass, objSuccessPage.CheckSuccessForm());
                Assert.True(true, "Overall steps has been successful");
            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }
        }
        [Test]
        public void TestUsingAnotherCard()
        {
            _test = extent.StartTest("Test without country", "Field country is empty at checkout page");

            //Data initialization
            CreateBookData createBookData = new CreateBookData("Username", 5, 31, 1, 5);
            NewCustomerMessageData messageData = new NewCustomerMessageData("testname2", "testmail@gmail.com");
            CheckoutAddressData checkoutAddressData = new CheckoutAddressData("Username2", "Userlastname2", " ", "Moscow", "576576", "+3806215451564");
            CheckoutPaymentData checkoutPaymentData = new CheckoutPaymentData("424", "123", "12", "17");
            //Page Objects initialization
            CreateBookPage objCreateBookPage = new CreateBookPage(_waitDriver, createBookData);
            PreviewPage objPreviewPage = new PreviewPage(_waitDriver);
            MessagePage objMessagePage = new MessagePage(_waitDriver);
            BagPage objBagPage = new BagPage(_waitDriver);
            CheckOutPage objCheckOutPage = new CheckOutPage(_waitDriver, checkoutPaymentData);
            SuccessPage objSuccessPage = new SuccessPage(_waitDriver);

            try
            {
                //Methods
                _test.Log(LogStatus.Pass, objCreateBookPage.LoginIntoBookData());
                _test.Log(LogStatus.Pass, objPreviewPage.GetPreviewPageTitle());
                _test.Log(LogStatus.Pass, objMessagePage.LoginNewCustomer(messageData));
                _test.Log(LogStatus.Pass, objBagPage.GetBagPageTitle());
                _test.Log(LogStatus.Pass, objCheckOutPage.LoginIntoShippingAddress(checkoutAddressData));
                _test.Log(LogStatus.Pass, objCheckOutPage.PaymentAddress());
                _test.Log(LogStatus.Pass, objSuccessPage.CheckSuccessForm());
                Assert.True(true, "Overall steps has been successful");
            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }
        }
        [Test]
        public void TestUsingAnotherCard4()
        {
            _test = extent.StartTest("Negative test email", "Email field is incorrect at Message page");
          
            //Data initialization
            CreateBookData createBookData = new CreateBookData("Username", 5, 31, 1, 5);
            NewCustomerMessageData messageData = new NewCustomerMessageData("testname2", "testmail@.com");
            CheckoutAddressData checkoutAddressData = new CheckoutAddressData("Username2", "Userlastname2", "Belarus ", "Minsk", "576576", "+3806215451564");
            CheckoutPaymentData checkoutPaymentData = new CheckoutPaymentData("424", "123", "12", "17");
            //Page Objects initialization
            CreateBookPage objCreateBookPage = new CreateBookPage(_waitDriver, createBookData);
            PreviewPage objPreviewPage = new PreviewPage(_waitDriver);
            MessagePage objMessagePage = new MessagePage(_waitDriver);
            BagPage objBagPage = new BagPage(_waitDriver);
            CheckOutPage objCheckOutPage = new CheckOutPage(_waitDriver, checkoutPaymentData);
            SuccessPage objSuccessPage = new SuccessPage(_waitDriver);

            try
            {
                //Methods
                _test.Log(LogStatus.Pass, objCreateBookPage.LoginIntoBookData());
                _test.Log(LogStatus.Pass, objPreviewPage.GetPreviewPageTitle());
                _test.Log(LogStatus.Pass, objMessagePage.LoginNewCustomer(messageData));
                _test.Log(LogStatus.Pass, objBagPage.GetBagPageTitle());
                _test.Log(LogStatus.Pass, objCheckOutPage.LoginIntoShippingAddress(checkoutAddressData));
                _test.Log(LogStatus.Pass, objCheckOutPage.PaymentAddress());
                _test.Log(LogStatus.Pass, objSuccessPage.CheckSuccessForm());
                Assert.True(true, "Overall steps has been successful");
            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }
        }
        [Test]
        public void TestUsingAnotherCard5()
        {
            _test = extent.StartTest("Positive test", "All correct");

            //Data initialization
            CreateBookData createBookData = new CreateBookData("Username", 5, 31, 1, 5);
            NewCustomerMessageData messageData = new NewCustomerMessageData("testname2", "testmail@gmail.com");
            CheckoutAddressData checkoutAddressData = new CheckoutAddressData("Username2", "Userlastname2", "Userstreet", "Moscow", "576576", "+3806215451564");
            CheckoutPaymentData checkoutPaymentData = new CheckoutPaymentData("424", "123", "12", "1");
            //Page Objects initialization
            CreateBookPage objCreateBookPage = new CreateBookPage(_waitDriver, createBookData);
            PreviewPage objPreviewPage = new PreviewPage(_waitDriver);
            MessagePage objMessagePage = new MessagePage(_waitDriver);
            BagPage objBagPage = new BagPage(_waitDriver);
            CheckOutPage objCheckOutPage = new CheckOutPage(_waitDriver, checkoutPaymentData);
            SuccessPage objSuccessPage = new SuccessPage(_waitDriver);

            try
            {
                //Methods
                _test.Log(LogStatus.Pass, objCreateBookPage.LoginIntoBookData());
                _test.Log(LogStatus.Pass, objPreviewPage.GetPreviewPageTitle());
                _test.Log(LogStatus.Pass, objMessagePage.LoginNewCustomer(messageData));
                _test.Log(LogStatus.Pass, objBagPage.GetBagPageTitle());
                _test.Log(LogStatus.Pass, objCheckOutPage.LoginIntoShippingAddress(checkoutAddressData));
                _test.Log(LogStatus.Pass, objCheckOutPage.PaymentAddress());
                _test.Log(LogStatus.Pass, objSuccessPage.CheckSuccessForm());
                Assert.True(true, "Overall steps has been successful");
            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }
        }
        [Test]
        public void TestUsingAnotherCard2()
        {
            _test = extent.StartTest("TestUsingAnotherCard2", "desc");

            //Data initialization
            CreateBookData createBookData = new CreateBookData("pro", 5, 31, 1, 5);
            NewCustomerMessageData messageData = new NewCustomerMessageData("testname2", "testmail@gmail.com");
            CheckoutAddressData checkoutAddressData = new CheckoutAddressData("Username2", "Userlastname2", "Hvardeisky ", "Moscow", "", "+3806215451564");
            CheckoutPaymentData checkoutPaymentData = new CheckoutPaymentData("424", "123", "12", "17");
            //Page Objects initialization
            CreateBookPage objCreateBookPage = new CreateBookPage(_waitDriver, createBookData);
            PreviewPage objPreviewPage = new PreviewPage(_waitDriver);
            MessagePage objMessagePage = new MessagePage(_waitDriver);
            BagPage objBagPage = new BagPage(_waitDriver);
            CheckOutPage objCheckOutPage = new CheckOutPage(_waitDriver, checkoutPaymentData);
            SuccessPage objSuccessPage = new SuccessPage(_waitDriver);

            try
            {
                //Methods
                _test.Log(LogStatus.Pass,  objCreateBookPage.LoginIntoBookData());
                _test.Log(LogStatus.Pass, objPreviewPage.GetPreviewPageTitle());
                _test.Log(LogStatus.Pass, objMessagePage.LoginNewCustomer(messageData));
                _test.Log(LogStatus.Pass, objBagPage.GetBagPageTitle());
                _test.Log(LogStatus.Pass, objCheckOutPage.LoginIntoShippingAddress(checkoutAddressData));
                _test.Log(LogStatus.Pass, objCheckOutPage.PaymentAddress());
                _test.Log(LogStatus.Pass, objSuccessPage.CheckSuccessForm());
                
                Assert.True(true, "Overall steps has been successful");
            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }
       }
         */
        [TearDown]
        public void Close()
        {
            VerifyNegativeLog(_test, _webDriver);
          
            extent.EndTest(_test);
            extent.Flush();
            _webDriver.Quit();
        }
    }
}
