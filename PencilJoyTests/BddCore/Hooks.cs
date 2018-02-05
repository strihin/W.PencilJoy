using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PencilJoyTests.Data;
using TechTalk.SpecFlow;

namespace PencilJoyTests.BddCore 
{
    [Binding]
    public sealed class Hooks 
    {
        public static IWebDriver WebDriver;
        public static WebDriverWait WaitDriver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            WebDriver = new ChromeDriver();
            WebDriver.Navigate().GoToUrl(Helper.StartPage);

            WaitDriver = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(11));
            FullAdminData.LoadJson();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            WebDriver.Quit();
            WebDriver.Dispose();
        }
    }
}