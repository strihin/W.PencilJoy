using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PencilJoyTests.Data;
//using RelevantCodes.ExtentReports;
using TechTalk.SpecFlow;

namespace PencilJoyTests.BddCore 
{
    [Binding]
    public sealed class Hooks 
    {
        private IWebDriver _webDriver;
        private WebDriverWait _waitDriver;
  
        [BeforeScenario]
        public void BeforeScenario()
        {
            _webDriver = new ChromeDriver();
            //  _webDriver = new FirefoxDriver();
            //  _webDriver.Manage().Window.Maximize();
            _waitDriver = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(11));
            _webDriver.Navigate().GoToUrl("http://penciljoy.altsolution.ua/");
            FullAdminData.LoadJson();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _webDriver.Quit();
        }
       
    }
}
