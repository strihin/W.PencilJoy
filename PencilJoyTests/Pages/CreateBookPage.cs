using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PencilJoyTests.Data;

namespace PencilJoyTests.Pages
{
    class CreateBookPage
    {
        private readonly WebDriverWait _waitDriver;
        private CreateBookData _createBookData;

        public CreateBookPage() { }
        public CreateBookPage(WebDriverWait waitDriver, CreateBookData createBookData)
        {
            _waitDriver = waitDriver;
            _createBookData = createBookData;
        }

       #region Object
        private IWebElement FirstNameTextBox 
        {
            get 
            { 
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Name("name")));
            }
        }
        private IWebElement BirthmonthDropdown
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Name("month")));
            }
        }
        private IWebElement BirthdayDropdown
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Name("date")));
            }
        }
        private IWebElement GenderPersonDropdown
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#create-child > div.cc-block.gender > div.cc-btns > a:nth-child(" + _createBookData.NumberSex + ")")));
            }
        }
        private IWebElement CharacterPersonDropItem
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(_createBookData.SelectorForCharacterPerson + " > div.sc-list > ul > li:nth-child(" + _createBookData.NumberCharacter + ")")));
            }
        }
        private IWebElement PreviewYourBookButton
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#create-child > div.cc-block.submit > input[type='submit']")));
            }
        }
        private IWebElement CurrencySelect
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Id("g-currency-switch")));
            }
        }
        #endregion

       #region Methods
       public void EditCurrency(int indexForCurrency)
        {
            SelectElement currencyItem = new SelectElement(CurrencySelect);
            currencyItem.SelectByIndex(indexForCurrency);
        }

       public virtual string LoginNameAndDate(string username, int numberMonth, int numberDay)
       {
           var monthSelect = new SelectElement(BirthmonthDropdown);
           var daySelect = new SelectElement(BirthdayDropdown);

           FirstNameTextBox.Clear();
           FirstNameTextBox.SendKeys(username);
           BirthmonthDropdown.Click();
           monthSelect.SelectByIndex(numberMonth - 1);
           BirthdayDropdown.Click();
           daySelect.SelectByIndex(numberDay - 1);

            return System.Reflection.MethodBase.GetCurrentMethod().Name ;
        }

        public virtual string LoginPersonCharacter(int numberSex, int numberCharacter)
        {
            _createBookData.NumberSex = numberSex;
            _createBookData.NumberCharacter = numberCharacter;
            GenderPersonDropdown.Click();
            CharacterPersonDropItem.Click();

            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }
        // comment
        public virtual string LoginIntoBookData(string username, int numberMonth, int numberDay, int numberSex, int numberCharacter)
        {
            var monthSelect = new SelectElement(BirthmonthDropdown);
            var daySelect = new SelectElement(BirthdayDropdown);

            FirstNameTextBox.Clear();
            FirstNameTextBox.SendKeys(username);
            BirthmonthDropdown.Click();
            monthSelect.SelectByIndex(numberMonth - 1);
            BirthdayDropdown.Click();
            daySelect.SelectByIndex(numberDay - 1);
            GenderPersonDropdown.Click();
            CharacterPersonDropItem.Click();
           
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }
        
     /// <summary>
     /// 
     /// </summary>
     /// <returns></returns>
        public  string ConfirmForm()
        {
            PreviewYourBookButton.SendKeys(Keys.Enter);
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }
        public bool VerifyErrorField(string fieldName)
        {
            IWebElement parentElement = Helper.SearchFieldByName(_waitDriver, fieldName);
            return Helper.SearchErrorField(parentElement);
        }
        #endregion
    }
}
