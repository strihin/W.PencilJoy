using System;
using System.IO;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;

namespace PencilJoyTests.ReportCore
{
    public class ExtentScreenshoter
    {
        public ExtentReports extent = ExtentManager.GetInstance();
        
        public static string TakeScreenShot(IWebDriver webDriver, ExtentTest test)
        {
            string fullPathScr = ExtentManager.GetPath() + "\\" + "Src" + 
                    DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") +".jpeg";
            ITakesScreenshot screenshotDriver = webDriver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(fullPathScr, ScreenshotImageFormat.Jpeg);
            return fullPathScr;
        }
      
        public static void VerifyNegativeLog(ExtentTest _test, IWebDriver _webDriver)
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
                var errorMessage = TestContext.CurrentContext.Result.Message;

                _test.Log(LogStatus.Fail, stackTrace + "\nSnapshot below: " + _test.AddScreenCapture(TakeScreenShot(_webDriver, _test)));
                _test.Log(LogStatus.Info, errorMessage);
            }
        }
       
    }
}
