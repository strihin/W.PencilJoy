using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PencilJoyTests.Data;

namespace PencilJoyTests.Pages
{
    class MessagePage
    {
        private WebDriverWait _waitDriver;

        public MessagePage() { }
        public MessagePage(WebDriverWait waitDriver)
        {
            _waitDriver = waitDriver;
        }      

        #region Objects
        private IWebElement MessageTextarea
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Name("message")));
            }
        }     
        private IWebElement NameCustomerTextbox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Id("name")));
            }
        }
        private IWebElement EmailCustomerTextbox
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Id("email")));
            }
        }
        private IWebElement NextButton
        {
            get
            {   
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(
                    By.CssSelector("#personalmesssage > input.btn.blue-btn.shadow")));
            }
        }
        #endregion

        #region Methods
        public void LoginMessageText(string message)
        {
            MessageTextarea.SendKeys(message);
        }
        public string LoginCustomerData(MessageData messageData)
        {
            NameCustomerTextbox.SendKeys(messageData.CustomerName);
            EmailCustomerTextbox.SendKeys(messageData.CustomerEmail);
            NextButton.SendKeys(Keys.Enter);
            return System.Reflection.MethodBase.GetCurrentMethod().Name ;
        }
        #endregion
    }
}
