using System;
using AventStack.ExtentReports;
//using RelevantCodes.ExtentReports;
namespace PencilJoyTests.ReportCore
{
    static class ExtentManager
    {
        private static ExtentReports extent;
        private static ExtentTest test;

        public static ExtentReports GetInstance()
        {
            if (extent == null)
            {
                extent = new ExtentReports();
                 //   (GetPath() + "\\report" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".html");
              //  extent.LoadConfig(Directory.GetCurrentDirectory() + "extent-config.xml");
                extent.AddSystemInfo("Selenium version", "2.53");
                extent.AddSystemInfo("Browser", "Prod");
               
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
