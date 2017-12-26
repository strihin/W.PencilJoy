using System.Collections.Generic;
using System.Runtime.InteropServices;
using AventStack.ExtentReports.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PencilJoyTests.Data;


namespace PencilJoyTests.Pages
{
    class CheckoutShippingAddressPage
    {  
        private WebDriverWait _waitDriver;
        private CheckoutAddressData checkoutShippingAddressData;
        private string previousFieldValue;

        public CheckoutShippingAddressPage()
        {
            
        }
        public CheckoutShippingAddressPage(WebDriverWait waitDriver)
        {
            _waitDriver = waitDriver;
        }
        public CheckoutShippingAddressPage(WebDriverWait waitDriver, CheckoutAddressData checkoutAddressData)
        {
            _waitDriver = waitDriver;
            this.checkoutShippingAddressData = checkoutAddressData;
        }
        #region Objects Shipping Address
        private IWebElement  FirstNameTextBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("sa-firstname")));
            }
        }
        private IWebElement LastNameTextBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("sa-lastname")));
            }
        }
        private IWebElement StreetAddressTextBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("sa-address")));
            }
        }
        private IWebElement CityTextBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("sa-city")));
              
            }
        }
        private IWebElement StateRegionDropdown
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("sa-spg-us")));
            }
        }
        private IWebElement ZipCodeTextBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("sa-code")));
            }
        }
        private IWebElement CountryDropdown
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("sa-country")));
            }
        }
        private IWebElement RegionDropdown
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("sa-spg-us")));
            }
        }
        private IWebElement RegionTextbox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("sa-spg-any")));
            }
        }
        private IWebElement PhoneTextBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.Id("sa-tel")));
            }
        }
        private IWebElement BillToTheAddressCheckBox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.CssSelector("#newcustomer > div:nth-child(1) > div.form-block > label")));
            }
        }
        #endregion

        #region Methods
        public string LoginIntoShippingAddress()
        {
            SelectElement selectCountry = new SelectElement(CountryDropdown);

            FirstNameTextBox.SendKeys(checkoutShippingAddressData.Username);
            LastNameTextBox.SendKeys(checkoutShippingAddressData.Lastname);
            StreetAddressTextBox.SendKeys(checkoutShippingAddressData.Street);
            ZipCodeTextBox.SendKeys(checkoutShippingAddressData.ZipCode);
            CountryDropdown.SendKeys(Keys.Enter);
            selectCountry.SelectByIndex(checkoutShippingAddressData.NumberCountry);
            CityTextBox.SendKeys(checkoutShippingAddressData.City);
            PhoneTextBox.SendKeys(checkoutShippingAddressData.Phone);
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }
        public string LoginIntoShippingAddress(string Username, string Lastname, string Street, string City, string ZipCode, string Phone, int NumberCountry, string Region)
        {
            SelectElement selectCountry = new SelectElement(CountryDropdown);
            SelectElement selectRegion = new SelectElement(StateRegionDropdown);

         //   ClearInputs();
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

        public string SelectCountryField(string CountryName)
        {
            SelectElement selectCountry = new SelectElement(CountryDropdown);
            CountryDropdown.SendKeys(Keys.Enter);
            selectCountry.SelectByText(CountryName);

            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }
        public string BillToThisAddress()
        {
            BillToTheAddressCheckBox.SendKeys(Keys.Enter);
            return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }

        public List<IWebElement> getElements()
        {
            return new List<IWebElement>(new List<IWebElement> 
            { FirstNameTextBox, LastNameTextBox, StreetAddressTextBox, ZipCodeTextBox, CountryDropdown, StateRegionDropdown, CityTextBox, PhoneTextBox });

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

        public bool DoesDropdownExist()
        {
            return RegionDropdown.Displayed;
        }

        public bool DoesTextboxExist()
        {
            return RegionTextbox.Displayed;
        }

        public IWebElement findoutElement(string fieldName, string blockName)
        {
            IWebElement outherBlockName = Helper.SearchFieldByName(_waitDriver, blockName);
            IWebElement innerBlockName = Helper.SearchInputBlock(outherBlockName, fieldName);
            return Helper.SearchInnerInput(innerBlockName);
        }

        public bool IsFieldEmpty(IWebElement foundElement)
        {
            return foundElement.Text.IsNullOrEmpty();
        }
        public void RemoveField(IWebElement foundElemenent)
        {
            foundElemenent.Clear();
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

        public bool AreElementsRequired(string blockName)
        {
             return Helper.SearchErrorInputs(Helper.SearchFieldByName(_waitDriver, blockName));
        }

        public bool IsElementRequired(string blockName, string fieldName)
        {
            IWebElement blockElement = Helper.SearchFieldByName(_waitDriver, blockName);
            return Helper.SearchErrorInput(blockElement, fieldName);
        }
        public bool AreElementsDisabled(string blockName)
        {
            
            List<IWebElement> webList = Helper.SearchElementsInnerBlock(Helper.SearchFieldByName(_waitDriver, blockName));
            int counter = webList.Count;
            foreach (var webelement in webList)
            {
                if (Helper.IsAttribtuePresent(webelement, "disabled"))
                {
                    counter--;
                }
            }
            return (counter==0);
        }
        #endregion
    }
}
