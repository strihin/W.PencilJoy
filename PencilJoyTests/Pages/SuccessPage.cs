using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PencilJoyTests.Pages
{
    class SuccessPage
    {
       private WebDriverWait _waitDriver;

        public SuccessPage() { }
        public SuccessPage(WebDriverWait waitDriver)
        {
            _waitDriver = waitDriver;
        }

        #region Objects
        private IWebElement SuccessfullCheckoutForm
        {
            get
            {
                return _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("form-msg")));
            }
        }
        #endregion

        #region Methods
        public string CheckSuccessForm()
        {
             if(SuccessfullCheckoutForm.Displayed)
                Assert.True(true, "Payment is succesfull");
            else
                Assert.Fail();
             return System.Reflection.MethodBase.GetCurrentMethod().Name ;
        }
        #endregion
        
    
    }
}
