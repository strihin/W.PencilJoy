using System;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace PencilJoyTests.ReportCore
{
    public class ExtentScreenshoter
    {
        public ExtentHtmlReporter extent = ExtentManager.GetInstance();
        
        public static string TakeScreenShot(IWebDriver webDriver, ExtentTest test)
        {
            string fullPathScr = ExtentManager.GetPath() + "\\" + "Src" + 
                    DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") +".jpeg";
            ITakesScreenshot screenshotDriver = webDriver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(fullPathScr, System.Drawing.Imaging.ImageFormat.Jpeg);
            return fullPathScr;
        }
      
        public static void VerifyNegativeLog(ExtentTest _test, IWebDriver _webDriver)
        {
            if (TestContext.CurrentContext.Result.Status == TestStatus.Failed)
            {
                var stackTrace = "<pre>" + TestContext.CurrentContext.Result.State + "</pre>";
               var errorMessage = TestContext.CurrentContext.Result.State;

                _test.Log(Status.Fail, stackTrace + "\nSnapshot below: " + _test.AddScreenCaptureFromPath(TakeScreenShot(_webDriver, _test)));
                _test.Log(Status.Info, "Error");
            }
        }
       
    }
}
