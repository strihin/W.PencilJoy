using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
using System.Threading;

namespace PencilJoy
{
    class CreateBookPage
    {
        IWebDriver webDriver;   

        #region DataForObjects
        public string Username { get; set; }
        public int NumberMonth { get; set; }
        public int NumberDay { get; set; }
        public int NumberSex { get; set; }
        public int NumberCharacter { get; set; }
        #endregion

        public CreateBookPage(IWebDriver webDriver, string username, int numberDay, int numberMonth, int numberSex, int numberCharacter)
        {
            this.webDriver = webDriver;
            this.Username = username;
            this.NumberDay = numberDay;
            this.NumberMonth = numberMonth;
            this.NumberSex = numberSex;
            this.NumberCharacter = numberCharacter;

        }

        public void CreateBookPag(string username, int numberDay, int numberMonth, int numberSex, int numberCharacter)
        {
            this.Username = username;
            this.NumberDay = numberDay;
            this.NumberMonth = numberMonth;
            this.NumberSex = numberSex;
            this.NumberCharacter = numberCharacter;
        }

        #region Objects

        private IWebElement FirstNameTextBox
        {
            get
            {
                return webDriver.FindElement(By.Name("name"));
            }
        }      
        private IWebElement BirthmonthDropdown
        {
            get
            {            
                return webDriver.FindElement(By.Name("month"));
            }
        }
        private IWebElement BirthmonthDropItem
        {            
            get
            {
                return webDriver.FindElement(By.CssSelector("#select-month > option:nth-child("+NumberMonth+")"));
            }
        }
        private IWebElement BirthdayDropdown
        {
            get
            {            
                return webDriver.FindElement(By.Name("date"));
            }
        }
        private IWebElement BirthdayDropItem
        {
            get
            {
                return webDriver.FindElement(By.CssSelector("#select-date > option:nth-child("+NumberDay+")"));
            }
        }
        private IWebElement GenderPersonDropdown
        {
            get
            {

                return webDriver.FindElement(By.CssSelector("#create-child > div.cc-block.gender > div.cc-btns > a:nth-child("+NumberSex+")"));
            }
        }
        private IWebElement CharacterPersonDropItem
        {
            get
            {//#select-girl > div.sc-list > ul > li:nth-child(3)
                return webDriver.FindElement(By.CssSelector("#select-girl > div.sc-list > ul > li:nth-child(3)"));
            }
        }
        private IWebElement PreviewYourBookButton
        {
            get
            {
                return webDriver.FindElement(By.CssSelector("#create-child > div.cc-block.submit > input[type='submit']"));//LinkText("Preview Your Book"));
            }
        }
        #endregion

        #region Methods


    
        public string LoginIntoBookData()
        {
           webDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            FirstNameTextBox.SendKeys(Username);

            BirthmonthDropdown.Click();
            BirthmonthDropItem.Click();

            BirthdayDropdown.Click();
            BirthdayDropItem.Click();

            GenderPersonDropdown.Click();
            CharacterPersonDropItem.Click();

            string LoginIntoBookData = webDriver.Title;
           
            PreviewYourBookButton.Click();                 
           
            return LoginIntoBookData;
        }
        #endregion
        
    }
}
