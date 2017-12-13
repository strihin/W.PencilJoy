using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PencilJoyTests
{
    static class Helper
    {
        internal const string StartPage = "https://books.penciljoy.com";
       
        public static bool SearchErrorField(IWebElement parentElement)
        {
            IReadOnlyList<IWebElement> childs = parentElement.FindElements(By.XPath(".//*"));
            foreach (var element in childs)
            {
                if ((element.GetAttribute("class") == "error"))
                {
                    return true;
                }
            }
            return false;
        }

        public static IWebElement SearchFieldByName(WebDriverWait driver, string textSearch)
        {
            return driver.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//*[text()='"+textSearch+"']/..")));
        }

    }
}
