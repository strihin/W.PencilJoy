using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using PencilJoy.Pages;
using PencilJoy.Tests;

namespace PencilJoy
{
    [TestFixture]
    class Program
    {
        static void Main(string[] args)        {           }

        IWebDriver webDriver;

        [SetUp]
        public void InitializeBrowser()
        {
         //   webDriver = new ChromeDriver();
            webDriver = new FirefoxDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            webDriver.Navigate().GoToUrl("http://penciljoy.altsolution.ua/");
        }
        /*
        [Test]
        public void CorrectDataForCreateBookPage()
        {

            CreateBookPage ObjCreateBookPage = new CreateBookPage(webDriver, "Lola", 8, 9, 2, 3);
          //  ObjCreateBookPage.CreateBookPag("Lola", 8, 9, 2, 3);
        }
        */
        [Test]
        public void TestLoginBookData()
        {

            CreateBookPage ObjCreateBookPage = new CreateBookPage(webDriver, "Username", 4, 5, 2, 2);//(webDriver, "Lola", 2, 2, 2, 3);
            PreviewPage ObjPreviewPage = new PreviewPage(webDriver);
            MessagePage ObjMessagePage = new MessagePage(webDriver);
            BagPage ObjBagPage = new BagPage(webDriver);
            CheckOutPage ObjCheckOutPage = new CheckOutPage(webDriver);
            SuccessPage ObjSuccessPage = new SuccessPage(webDriver);
            DataGeneration DatGen = new DataGeneration();

            //initialize CreateBook
           // ObjCreateBookPage.CreateBookPag("Lola", 3, 2, 2, 3);
            string CreateBookPageTitle = ObjCreateBookPage.LoginIntoBookData();
          //  Assert.AreEqual("Personalized Books and Gifts from Pencil Joy", CreateBookPageTitle);
            Thread.Sleep(2000);    
            string PreviewPageTitle = ObjPreviewPage.GetPreviewPageTitle();
          //  Assert.AreEqual("Personalized Books and Gifts from Pencil Joy Preview", PreviewPageTitle);
            Thread.Sleep(2000);
            string MessagePageTitle = ObjMessagePage.loginCustomerData("testname","testmail@gmail.com");
          //  Assert.AreEqual("Personalized Books and Gifts from Pencil Joy Message", MessagePageTitle);
            Thread.Sleep(2000);
            string BagPageTitle = ObjBagPage.GetBagPageTitle();
          //  Assert.AreEqual("Personalized Books and Gifts from Pencil Joy Bag", BagPageTitle);
            Thread.Sleep(2000);
             ObjCheckOutPage.LoginIntoShippingAddress("Username", "lastname", "street", "Sever", "101010", "+3890829027092");
            // ObjCheckOutPage.BillToThisAddress();
            string CheckoutPageTitle = ObjCheckOutPage.PaymentAddress("4242", "123");
         //   Assert.AreEqual("Personalized Books and Gifts from Pencil Joy Checkout", CheckoutPageTitle);

            string ObjSuccessPageTitle = ObjSuccessPage.CheckSuccessForm();
            Assert.AreEqual("Personalized Books and Gifts from Pencil Joy Success", CheckoutPageTitle);

        }
        [TearDown]
        public void Close()
        {
            webDriver.Quit();

        }
    }
}
