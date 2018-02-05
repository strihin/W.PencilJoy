//using NUnit.Framework;
//using System;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support.UI;
//using PencilJoyTests.BddCore;
//using PencilJoyTests.Data;
//using PencilJoyTests.Maths;
//using PencilJoyTests.Pages;

//namespace PencilJoyTests
//{
//    [TestFixture]
//    public class TestClass 
//    {

        
        
  
//        [SetUp]
//        public void InitializeBrowser()
//        {
//            Hooks.WebDriver = new ChromeDriver();
//        //  Hooks.WebDriver = new FirefoxDriver();
//        //  Hooks.WebDriver.Manage().Window.Maximize();
//            Hooks.WaitDriver = new Hooks.WebDriverWait(Hooks.WebDriver, TimeSpan.FromSeconds(11));
//            Hooks.WebDriver.Navigate().GoToUrl("http://penciljoy.altsolution.ua/");
//            FullAdminData.LoadJson();
//        }
 
//         [Test]
//        public void RemindMeLater()
//        {
//             PreviewMaths previewMath = new PreviewMaths();
//             BagMaths bagMath = new BagMaths();
//             CheckoutMaths checkoutMath = new CheckoutMaths(bagMath);

//            //Data initialization
//            CreateBookData createBookData = new CreateBookData();
//            CreateBookData editBookData = new CreateBookData();
//            MessageAndIdentificationData messageData = new MessageAndIdentificationData();
//            BagPageData bagPageData = new BagPageData("vip25", "USD");
//            CheckoutAddressData checkoutShippingData = new CheckoutAddressData();
//            CheckoutAddressData checkOutBillingData = new CheckoutAddressData();
//            CheckoutPaymentData checkoutPaymentData = new CheckoutPaymentData();

//            PaypalPaymentData paypalPaymentData = new PaypalPaymentData("maxim-buyer-2@altsolution.net", "12345678");
            
//            //Page Objects initialization
//            CreateBookPage objCreateBookPage = new CreateBookPage(createBookData);
//            EditBookPage objeditBookPage = new EditBookPage(editBookData);
//            PreviewPage objPreviewPage = new PreviewPage(previewMath);
//            MessageAndIdentificationPage objMessagePage = new MessageAndIdentificationPage(messageData);
//            BagPage objBagPage = new BagPage(bagMath, bagPageData);
//            CheckoutShippingAddressPage objCheckoutShippingAddressPage = new CheckoutShippingAddressPage(checkoutShippingData);
//            CheckoutBillingAddressPage objCheckoutBillingAddressPage = new CheckoutBillingAddressPage(checkOutBillingData);
//            CheckoutPaymentPage objCheckoutPaymentPage = new CheckoutPaymentPage(checkoutPaymentData, checkoutMath);
//            PaypalPaymentPage objPaypalPaymentPage = new PaypalPaymentPage();
//            SuccessfulOrderPage successfulOrderPage = new SuccessfulOrderPage(Hooks.WaitDriver);
           
//            try
//            {
//            //    //Methods
//            //    _test.Log(Status.Pass, objCreateBookPage.LoginNameAndDate());
//            //    _test.Log(Status.Pass, objCreateBookPage.ConfirmForm());
//            //    _test.Log(Status.Pass, objPreviewPage.EditCurrency());
//            //    _test.Log(Status.Pass, objPreviewPage.ConfirmGeneralForm());

//            //    _test.Log(Status.Pass, objMessagePage.EditMessage());
//            //    _test.Log(Status.Pass, objMessagePage.LoginNewCustomer());
//            //    _test.Log(Status.Pass, objMessagePage.ComfirmForm());

//            //    _test.Log(Status.Pass, objBagPage.ShopMoreBooks());
//            //    _test.Log(Status.Pass, objCreateBookPage.LoginNameAndDate());
//            //    _test.Log(Status.Pass, objCreateBookPage.ConfirmForm());
//            //    _test.Log(Status.Pass, objPreviewPage.ConfirmGeneralForm());
//            //    _test.Log(Status.Pass, objMessagePage.ComfirmForm());

//            //    objBagPage.CheckDiscount();

//            //    _test.Log(Status.Pass, objBagPage.ShopMoreBooks());
//            //    _test.Log(Status.Pass, objCreateBookPage.LoginNameAndDate());
//            //    _test.Log(Status.Pass, objCreateBookPage.ConfirmForm());
//            //    _test.Log(Status.Pass, objPreviewPage.ConfirmGeneralForm());
//            //    _test.Log(Status.Pass, objMessagePage.ComfirmForm());
            
//            //    _test.Log(Status.Pass, objBagPage.RemoveBook());
//            //    _test.Log(Status.Pass, objBagPage.ConfirmForm());
//            //    objCheckoutPaymentPage.GetMathPriceForCheckoutMath();

//            //    objCheckoutPaymentPage.GetMathPriceForCheckoutMath();
//            //    _test.Log(Status.Pass, objCheckoutShippingAddressPage.LoginIntoShippingAddress());
//            //    _test.Log(Status.Pass, objCheckoutShippingAddressPage.BillToThisAddress());
//            //    _test.Log(Status.Pass, objCheckoutBillingAddressPage.LoginIntoBillingAddress());
//            // //   objCheckoutPaymentPage.GetPriceAndDiscountCode();
//            //    objCheckoutPaymentPage.PaymentAddress();
//            ////    _test.Log(Status.Pass, objPaypalPaymentPage.FillFields(paypalPaymentData));
//            //    _test.Log(Status.Pass, successfulOrderPage.GetOrderNumber());
                
//                Assert.True(true, "Overall steps has been successful");
//            }
//            catch (Exception e)
//            {
//                Assert.Fail(e.ToString());
//            }
//        }
//        [TearDown]
//        public void Close()
//        {
//            //VerifyNegativeLog(_test, Hooks.WebDriver);
          
//            //extent.RemoveTest(_test);
//            //extent.Flush();
//            Hooks.WebDriver.Quit();
//        }
//    }
//}
