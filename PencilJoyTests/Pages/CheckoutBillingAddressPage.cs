using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PencilJoyTests.Data;

namespace PencilJoyTests.Pages
{
    internal class CheckoutBillingAddressPage
    {
        internal readonly WebDriverWait _waitDriver;
        internal CheckoutAddressData checkoutBillingAddressData;
        private string previousFieldValue;

        public CheckoutBillingAddressPage( )
        {
        }
        public CheckoutBillingAddressPage(WebDriverWait waitDriver)
        {
            _waitDriver = waitDriver;
        }
        public CheckoutBillingAddressPage(WebDriverWait waitDriver, CheckoutAddressData checkoutBillingAddressData)
        {
            _waitDriver = waitDriver;
            this.checkoutBillingAddressData = checkoutBillingAddressData;
        }
        #region Objects Shipping Address
        private IWebElement FirstNameTextBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("ba-firstname")));
            }
        }
        private IWebElement LastNameTextBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("ba-lastname")));
            }
        }
        private IWebElement StreetAddressTextBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("ba-address")));
            }
        }
        private IWebElement CityTextBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("ba-city")));
            }
        }
        private IWebElement StateRegionDropdown
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("ba-spg-us")));
            }
        }
     
        private IWebElement ZipCodeTextBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("ba-code")));
            }
        }
        private IWebElement CountryDropdown
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("ba-country")));
            }
        }
      
        private IWebElement PhoneTextBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("ba-tel")));
            }
        }
        private IWebElement BillToTheAddressCheckBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("the-bame-ship")));
            }
        }
        #endregion
        
        #region Methods

        public void ClearInputs()
        {
            FirstNameTextBox.Clear();
            LastNameTextBox.Clear();
            StreetAddressTextBox.Clear();
            CityTextBox.Clear();
            ZipCodeTextBox.Clear();
            PhoneTextBox.Clear();
        }
        public string LoginIntoBillingAddress()
        {
            SelectElement selectCountry = new SelectElement(CountryDropdown);
            ClearInputs();
            FirstNameTextBox.SendKeys(checkoutBillingAddressData.Username);
            LastNameTextBox.SendKeys(checkoutBillingAddressData.Lastname);
            StreetAddressTextBox.SendKeys(checkoutBillingAddressData.Street);
            ZipCodeTextBox.SendKeys(checkoutBillingAddressData.ZipCode);
            CountryDropdown.SendKeys(Keys.Enter);
            selectCountry.SelectByIndex(checkoutBillingAddressData.NumberCountry);
            CityTextBox.SendKeys(checkoutBillingAddressData.City);
            PhoneTextBox.SendKeys(checkoutBillingAddressData.Phone);
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }
        public string LoginIntoBillingAddress(string Username, string Lastname, string Street,  string City, string ZipCode, string Phone, int NumberCountry, string Region)
        {
            SelectElement selectCountry = new SelectElement(CountryDropdown);
            SelectElement selectRegion = new SelectElement(StateRegionDropdown);

            ClearInputs();
            FirstNameTextBox.SendKeys(Username);
            LastNameTextBox.SendKeys(Lastname);
            StreetAddressTextBox.SendKeys(Street);
            ZipCodeTextBox.SendKeys(ZipCode);
            CountryDropdown.SendKeys(Keys.Enter);
            selectCountry.SelectByIndex(NumberCountry);
            StateRegionDropdown.SendKeys(Keys.Enter);
            selectRegion.SelectByText(Region);
            CityTextBox.SendKeys(City);
            PhoneTextBox.SendKeys(Phone);

            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }
      
        public string ShipToThisAddress()
        {
            BillToTheAddressCheckBox.SendKeys(Keys.Enter);
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }
        public List<IWebElement> getElements()
        {
            return new List<IWebElement>(new List<IWebElement> { FirstNameTextBox, LastNameTextBox, StreetAddressTextBox, ZipCodeTextBox, CountryDropdown, StateRegionDropdown, CityTextBox, PhoneTextBox });

        }
        public bool AreEmptyFields()
        {
            var elementList = getElements();
            foreach (var elemItem in elementList)
            {
                if (elemItem.Text.IsNullOrEmpty())
                    return true;
            }
            return false;
        }

        public bool AreFieldsCorrect()
        {
            var elementList = getElements();
            foreach (var elemItem in elementList)
            {
                if (elemItem.GetAttribute("class") == "error")
                    return true;
            }
            return false;
        }
        public bool AreFieldsDisabled()
        {
            var elementList = getElements();
            foreach (var elemItem in elementList)
            {
                if (!Helper.IsAttribtuePresent(elemItem, "disabled"))
                    return false;
            }
            return true;
        }
        public string SelectCountryField(string CountryName)
        {
            SelectElement selectCountry = new SelectElement(CountryDropdown);
            CountryDropdown.SendKeys(Keys.Enter);
            selectCountry.SelectByText(CountryName);

            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }
        public void EditField(string fieldName, string fieldValue)
        {
            IWebElement fieldElement = Helper.SearchInnerInput(Helper.SearchFieldByName(_waitDriver, fieldName));
            previousFieldValue = fieldElement.Text;
            fieldElement.Clear();
            fieldElement.SendKeys(fieldValue);
        }

        public bool CompareValuesInTheField(string fieldName)
        {
            IWebElement fieldElement = Helper.SearchInnerInput(Helper.SearchFieldByName(_waitDriver, fieldName));
            return (fieldElement.Text != previousFieldValue);
        }
        #endregion
       
    }
}
