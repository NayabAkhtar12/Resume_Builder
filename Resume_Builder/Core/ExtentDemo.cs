using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AventStack.ExtentReports.Reporter;

namespace YourNamespace
{
    public class ExtentDemo
    {
        ExtentReports extent;
        ExtentTest test;

        [TestInitialize]
        public void Setup()
        {
            // Initialize ExtentReports and attach a report

            var extentSparkReporter = new ExtentSparkReporter(@"C:\Path\To\Your\Report.html");
            extent = new ExtentReports();
            extent.AttachReporter(extentSparkReporter);
        }

        [TestCleanup]
        public void TearDown()
        {
            // Flush the report
            extent.Flush();
        }
    }
}
