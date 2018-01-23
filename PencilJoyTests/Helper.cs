using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PencilJoyTests.Maths;

namespace PencilJoyTests
{
    static class Helper
    {
        internal const string StartPage = "https://books.penciljoy.com";

        public static Order ExpectedOrder { get; set; }
        public static Order ActualOrder { get; set; }
        
        internal static bool checkSubtotalPrice;
        internal static bool checkGrandPrice;
        internal static bool verifyCurrencyFirstBook;
        static internal bool verifyPriceFirstBook;

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

        public static bool SearchErrorInputs(IWebElement parentElement)
        {
            IReadOnlyList<IWebElement> childs = parentElement.FindElements(By.TagName("input"));
            foreach (var element in childs)
            {
                if ((element.GetAttribute("class") == "error"))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool SearchErrorInput(IWebElement blockName, string fieldName)
        {

            IWebElement child = blockName.FindElement(By.XPath(".//*[text()='" + fieldName + "']/.."));

            if ((child.GetAttribute("class") == "error"))
            {
                return true;
            }

            return false;
        }

        public static IWebElement SearchFieldByName(WebDriverWait driver, string textSearch)
        {
            return driver.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//*[text()='" + textSearch + "']/..")));
        }

        public static IWebElement SearchInputBlock(IWebElement webBlock, string textSearch)
        {
            return webBlock.FindElement(By.XPath(".//*[text()='" + textSearch + "']/.."));
        }
        public static IWebElement SearchInputDoubleBlock(IWebElement webBlock, string textSearch)
        {
            return webBlock.FindElement(By.XPath("/..//*[text()='" + textSearch + "']/"));
        }
        public static IWebElement SearchInnerInput(IWebElement webBlock)
        {
            return webBlock.FindElement(By.TagName("input"));
        }

        public static List<IWebElement> SearchElementsInnerBlock(IWebElement webBlock)
        {
            return webBlock.FindElements(By.TagName("input")).ToList();
        }
        public static bool IsAttribtuePresent(IWebElement element, String attribute)
        {
            bool result = false;
            try
            {
                String value = element.GetAttribute(attribute);
                if (value != null)
                {
                    result = true;
                }
            }
            catch (Exception e) { }

            return result;
        }
        public static bool CompareListBook(List<double> actualPriceBook, List<double> expectedPriceBook)
        {
            return expectedPriceBook.SequenceEqual(actualPriceBook);
        }
        public static bool ComparePrices(double actualPrice, double expectedPrice)
        {
            return (expectedPrice.Equals(actualPrice));
        }

    }
}