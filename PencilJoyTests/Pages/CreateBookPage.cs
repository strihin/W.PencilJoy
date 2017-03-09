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
        private IWebElement BirthmonthDropItem
        {            
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#select-month > option:nth-child(" + _createBookData.NumberMonth + ")")));
            }
        }
        private IWebElement BirthdayDropdown
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Name("date")));
            }
        }
        private IWebElement BirthdayDropItem
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#select-date > option:nth-child(" + _createBookData.NumberDay + ")")));
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
            SelectElement dropdown = new SelectElement(CurrencySelect);
            dropdown.SelectByIndex(indexForCurrency);
        }
        
        public string LoginIntoBookData()
        {
           FirstNameTextBox.SendKeys(_createBookData.Username);

            BirthmonthDropdown.Click();
            BirthmonthDropItem.Click();

            BirthdayDropdown.Click();
            BirthdayDropItem.Click();

            GenderPersonDropdown.Click();
            CharacterPersonDropItem.Click();

            PreviewYourBookButton.Click();

            return System.Reflection.MethodBase.GetCurrentMethod().Name ;
        }
        #endregion
    }
}
