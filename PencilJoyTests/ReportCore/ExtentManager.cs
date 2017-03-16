using System;
using System.IO;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace PencilJoyTests.ReportCore
{
    class ExtentManager
    {
        private static ExtentHtmlReporter extent;
        private static ExtentTest test;

        public static ExtentHtmlReporter GetInstance()
        {
            if (extent == null)
            {
                extent = new ExtentHtmlReporter
                    (GetPath() + "\\report" + 
                    DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".html");
              
               
               
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
