using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PencilJoyTests.Data;
using RelevantCodes.ExtentReports;
using TechTalk.SpecFlow;
using RelevantCodes.ExtentReports;

namespace PencilJoyTests.BddCore : ExtentScreenshoter
{
    [Binding]
    public sealed class Hooks
    {
        private IWebDriver _webDriver;
        private WebDriverWait _waitDriver;
        private ExtentTest _test;
  
        [BeforeScenario]
        public void BeforeScenario()
        {
            _webDriver = new ChromeDriver();
            //  _webDriver = new FirefoxDriver();
            //  _webDriver.Manage().Window.Maximize();
            _waitDriver = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(11));
            _webDriver.Navigate().GoToUrl("http://penciljoy.altsolution.ua/");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            VerifyNegativeLog(_test, _webDriver);

            extent.EndTest(_test);
            extent.Flush();
            _webDriver.Quit();
        }

        [BeforeTestRun]
        public void BeforeTestRun()
        {
            FullAdminData.LoadJson();
        }
    }
}
