using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace PencilJoy.Pages
{
    class MessagePage
    {
        IWebDriver webDriver;

        public MessagePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }      

        #region Objects
        private IWebElement MessageTextarea
        {
            get
            {
                return webDriver.FindElement(By.Name("message"));
            }
        }     
        private IWebElement NameCustomerTextbox
        {
            get
            {
                return webDriver.FindElement(By.Id("name"));
            }
        }
        private IWebElement EmailCustomerTextbox
        {
            get
            {
                return webDriver.FindElement(By.Id("email"));
            }
        }
        private IWebElement NextButton
        {
            get
            {
                return webDriver.FindElement(By.CssSelector("#personalmesssage > input.btn.blue-btn.shadow"));
            }
        }
        #endregion

        #region Methods
        public void loginMessageText(string message)
        {
            MessageTextarea.SendKeys(message);
        }
        public string loginCustomerData(string customername, string customeremail)
        {
            NameCustomerTextbox.SendKeys(customername);
            EmailCustomerTextbox.SendKeys(customeremail);

            string MessagePageTitle = webDriver.Title;
            NextButton.Click();            
            return MessagePageTitle;
        }
        #endregion
    }
}
