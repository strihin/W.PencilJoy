using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using PencilJoyTests.ReportCore;
using PencilJoyTests.Data;
using PencilJoyTests.Pages;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

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
         // _webDriver = new FirefoxDriver();
            _webDriver.Manage().Window.Maximize();
            _waitDriver = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(11));
            _webDriver.Navigate().GoToUrl("http://penciljoy.altsolution.ua/");

        }

        [Test]
        public void TestUsingPayPal()
        {

            _test = extent.CreateTest("PayPal", "Payment by paypal. Page`s loaded long term");
            //Data initialization
            CreateBookData createBookData = new CreateBookData("UsernameXX", 4, 1, 1, 2);
            MessageData messageData = new MessageData("testname", "testmail@yahoo.com");
            CheckoutAddressData checkoutAddressData = new CheckoutAddressData("Username", "Userlastname", "Haharina ", "London", "101010", "+3890829027092");
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
                _test.Log(Status.Pass, objCreateBookPage.LoginIntoBookData());
                _test.Log(Status.Pass, objPreviewPage.GetPreviewPageTitle());
                _test.Log(Status.Pass, objMessagePage.LoginCustomerData(messageData));
                _test.Log(Status.Pass, objBagPage.GetBagPageTitle());
                _test.Log(Status.Pass, objCheckOutPage.LoginIntoShippingAddress(checkoutAddressData));
                _test.Log(Status.Pass, objCheckOutPage.PaymentMethodPaypal());
                _test.Log(Status.Pass, objPaypalPaymentPage.FillFields(paypalPaymentData));
                Assert.True(true, "Overall steps has been successful");
            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }
            
         }
        public void TestUsingPayPal2()
        {

            _test = extent.CreateTest("PayPal without username", "No data for username");
            //Data initialization
            CreateBookData createBookData = new CreateBookData("UsernameXX", 4, 1, 1, 2);
            MessageData messageData = new MessageData("testname", "testmail@yahoo.com");
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
                _test.Log(Status.Pass, objCreateBookPage.LoginIntoBookData());
                _test.Log(Status.Pass, objPreviewPage.GetPreviewPageTitle());
                _test.Log(Status.Pass, objMessagePage.LoginCustomerData(messageData));
                _test.Log(Status.Pass, objBagPage.GetBagPageTitle());
                _test.Log(Status.Pass, objCheckOutPage.LoginIntoShippingAddress(checkoutAddressData));
                _test.Log(Status.Pass, objCheckOutPage.PaymentMethodPaypal());
                _test.Log(Status.Pass, objPaypalPaymentPage.FillFields(paypalPaymentData));
                Assert.True(true, "Overall steps has been successful");
            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }

        }
        public void TestUsingPayPal3()
        {

            _test = extent.CreateTest("PayPal without phone number", "Field number phone is empty at checkout page");
            //Data initialization
            CreateBookData createBookData = new CreateBookData("UsernameXX", 4, 1, 1, 2);
            MessageData messageData = new MessageData("testname", "@yahoo.com");
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
                _test.Log(Status.Pass, objCreateBookPage.LoginIntoBookData());
                _test.Log(Status.Pass, objPreviewPage.GetPreviewPageTitle());
                _test.Log(Status.Pass, objMessagePage.LoginCustomerData(messageData));
                _test.Log(Status.Pass, objBagPage.GetBagPageTitle());
                _test.Log(Status.Pass, objCheckOutPage.LoginIntoShippingAddress(checkoutAddressData));
                _test.Log(Status.Pass, objCheckOutPage.PaymentMethodPaypal());
                _test.Log(Status.Pass, objPaypalPaymentPage.FillFields(paypalPaymentData));
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
            DataGeneration dg = new DataGeneration();
            _test = extent.CreateTest("Correct card", "Case should be positive");

            //Data initialization
            /*
            CreateBookData createBookData = new CreateBookData("Username", 5, 31, 1, 5);
            MessageData messageData = new MessageData("testname2", "testmail@gmail.com");
            CheckoutAddressData checkoutAddressData = new CheckoutAddressData("Username2", "Userlastname2", "Hvardeisky ", "Moscow", "576576", "+3806215451564");
            CheckoutPaymentData checkoutPaymentData = new CheckoutPaymentData("424", "123", "12", "17");
            */
            //Page Objects initialization
            CreateBookPage objCreateBookPage = new CreateBookPage(_waitDriver, dg.createBookData);
            PreviewPage objPreviewPage = new PreviewPage(_waitDriver);
            MessagePage objMessagePage = new MessagePage(_waitDriver);
            BagPage objBagPage = new BagPage(_waitDriver);
            CheckOutPage objCheckOutPage = new CheckOutPage(_waitDriver, dg.checkoutPaymentData);
            SuccessPage objSuccessPage = new SuccessPage(_waitDriver);

            try
            {
                //Methods
                _test.Log(Status.Pass, objCreateBookPage.LoginIntoBookData());
                _test.Log(Status.Pass, objPreviewPage.GetPreviewPageTitle());
                _test.Log(Status.Pass, objMessagePage.LoginCustomerData(dg.messageData));
                _test.Log(Status.Pass, objBagPage.GetBagPageTitle());
                _test.Log(Status.Pass, objCheckOutPage.LoginIntoShippingAddress(dg.checkoutAddressData));
                _test.Log(Status.Pass, objCheckOutPage.PaymentAddress());
                _test.Log(Status.Pass, objSuccessPage.CheckSuccessForm());
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
            _test = extent.CreateTest("Test without country", "Field country is empty at checkout page");

            //Data initialization
            CreateBookData createBookData = new CreateBookData("Username", 5, 31, 1, 5);
            MessageData messageData = new MessageData("testname2", "testmail@gmail.com");
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
                _test.Log(Status.Pass, objCreateBookPage.LoginIntoBookData());
                _test.Log(Status.Pass, objPreviewPage.GetPreviewPageTitle());
                _test.Log(Status.Pass, objMessagePage.LoginCustomerData(messageData));
                _test.Log(Status.Pass, objBagPage.GetBagPageTitle());
                _test.Log(Status.Pass, objCheckOutPage.LoginIntoShippingAddress(checkoutAddressData));
                _test.Log(Status.Pass, objCheckOutPage.PaymentAddress());
                _test.Log(Status.Pass, objSuccessPage.CheckSuccessForm());
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
            _test = extent.CreateTest("Negative test email", "Email field is incorrect at Message page");
          
            //Data initialization
            CreateBookData createBookData = new CreateBookData("Username", 5, 31, 1, 5);
            MessageData messageData = new MessageData("testname2", "testmail@.com");
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
                _test.Log(Status.Pass, objCreateBookPage.LoginIntoBookData());
                _test.Log(Status.Pass, objPreviewPage.GetPreviewPageTitle());
                _test.Log(Status.Pass, objMessagePage.LoginCustomerData(messageData));
                _test.Log(Status.Pass, objBagPage.GetBagPageTitle());
                _test.Log(Status.Pass, objCheckOutPage.LoginIntoShippingAddress(checkoutAddressData));
                _test.Log(Status.Pass, objCheckOutPage.PaymentAddress());
                _test.Log(Status.Pass, objSuccessPage.CheckSuccessForm());
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
            _test = extent.CreateTest("Positive test", "All correct");

            //Data initialization
            CreateBookData createBookData = new CreateBookData("Username", 5, 31, 1, 5);
            MessageData messageData = new MessageData("testname2", "testmail@gmail.com");
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
                _test.Log(Status.Pass, objCreateBookPage.LoginIntoBookData());
                _test.Log(Status.Pass, objPreviewPage.GetPreviewPageTitle());
                _test.Log(Status.Pass, objMessagePage.LoginCustomerData(messageData));
                _test.Log(Status.Pass, objBagPage.GetBagPageTitle());
                _test.Log(Status.Pass, objCheckOutPage.LoginIntoShippingAddress(checkoutAddressData));
                _test.Log(Status.Pass, objCheckOutPage.PaymentAddress());
                _test.Log(Status.Pass, objSuccessPage.CheckSuccessForm());
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
            _test = extent.CreateTest("TestUsingAnotherCard2", "desc");

            //Data initialization
            CreateBookData createBookData = new CreateBookData("pro", 5, 31, 1, 5);
            MessageData messageData = new MessageData("testname2", "testmail@gmail.com");
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
                _test.Log(Status.Pass,  objCreateBookPage.LoginIntoBookData());
                _test.Log(Status.Pass, objPreviewPage.GetPreviewPageTitle());
                _test.Log(Status.Pass, objMessagePage.LoginCustomerData(messageData));
                _test.Log(Status.Pass, objBagPage.GetBagPageTitle());
                _test.Log(Status.Pass, objCheckOutPage.LoginIntoShippingAddress(checkoutAddressData));
                _test.Log(Status.Pass, objCheckOutPage.PaymentAddress());
                _test.Log(Status.Pass, objSuccessPage.CheckSuccessForm());
                
                Assert.True(true, "Overall steps has been successful");
            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }
       }


        [TearDown]
        public void Close()
        {
            VerifyNegativeLog(_test, _webDriver);          
            
            extent.Flush();
            _webDriver.Quit();
        }
    }
}
