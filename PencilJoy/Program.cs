using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

using OpenQA.Selenium.Support.UI;


namespace PencilJoy
{
    class Program
    {
        // DataBook bookData = new DataBook("Lola", 2, 10, true, 2);
        [SetUp]
        public static void Initialize()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://penciljoy.altsolution.ua/");
            Console.WriteLine("Opened URL");
        }
        [SetUp]

        [Test]
        public void ExecuteTest(ChromeDriver driver)
        {
            driver.Navigate().GoToUrl("http://penciljoy.altsolution.ua/");
            var Name = driver.FindElement(By.XPath("//*[@id='create - child']/div[1]/input"));
            Name.Click();
            var BirthMonth = driver.FindElement(By.XPath("//*[@id='select-month']/option[" + 6 + "]"));
            var BirthDay = driver.FindElement(By.XPath("//*[@id='select-date']/option[" + 6 + "]"));
            var GenderPerson = driver.FindElement(By.XPath("//*[@id='create-child']/div[3]/div[1]/a[" + 1 + "]"));
            var CharacterPerson = driver.FindElement(By.XPath("//*[@id='select-boy']/div[2]/ul/li[" + 4 + "]"));

        }
        [Test]
        static void Main(string[] args)
        {
            Initialize();


                /*
            using (IWebDriver driver = new FirefoxDriver())
            {
                driver.Navigate().GoToUrl("http://penciljoy.altsolution.ua/");
                var Name = driver.FindElement(By.XPath("//*[@id='create - child']/div[1]/input"));
                Name.Click();
                var BirthMonth = driver.FindElement(By.XPath("//*[@id='select-month']/option["+6+"]"));
                var BirthDay = driver.FindElement(By.XPath("//*[@id='select-date']/option[" + 6 + "]"));
                var GenderPerson = driver.FindElement(By.XPath("//*[@id='create-child']/div[3]/div[1]/a["+1+"]"));                
                var CharacterPerson = driver.FindElement(By.XPath("//*[@id='select-boy']/div[2]/ul/li["+4+"]"));

            }
            */
        }
        /*
        driver.Click(Preview Your Book);
        driver.Click(ORDER FOR $29.99);
        */
    }
}
