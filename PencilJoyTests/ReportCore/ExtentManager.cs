using System;
using System.IO;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace PencilJoyTests.ReportCore
{
    class ExtentManager
    {
        private static ExtentReports extent;
        private static ExtentTest test;

        public static ExtentReports GetInstance()
        {           
            if (extent == null)
            {
                ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".html");
                htmlReporter.Configuration().
                 var extentxReporter = new ExtentXReporter();
                htmlReporter.Configuration().ReportName = "Build123";
                htmlReporter.Configuration().ProjectName = "MyProject";
                htmlReporter.Configuration().ServerURL = "http://localhost:1337/";

                htmlReporter.LoadConfig(GetPath() + "\\packages.config");
                extent.AttachReporter(htmlReporter, extentxReporter);      
            }
            return extent;
        }

        public static string GetPath()
        {
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string currentPath = new Uri(actualPath).LocalPath+ "\\Reports\\";
            return currentPath;
        }
    }
}
