using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using OpenQA.Selenium.Appium.Android;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ResumeBuilder.Pages
{
    //By default Its access modifier is Internal
    class ExTest
    {
        private AppiumDriver<IWebElement> driver;
        private ExtentTest test;

        public ExTest(AppiumDriver<IWebElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.test = test;
        }

        public void PersonalInfo_InValid()
        {
            try
            {
                try
                {
                    Name.SendKeys("Nayab Akhtar");
                    Assert.IsTrue(Name.Text.Equals("Nayab Akhtar"), "Failed Test Case");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Assertion failed: " + ex.Message);
                    test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    Designation.SendKeys("  12%^&*");
                    Assert.IsTrue(Designation.Text.Equals("SQA"), "Failed Test Case");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Assertion failed: " + e.Message);
                    test.Log(Status.Fail, $"Test failed due to: {e.Message}");
                }

                try
                {
                    PhoneNo.SendKeys("034988547664444444444444");
                    Assert.IsTrue(PhoneNo.Text.Equals("03578823844"), "Failed Test Case");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Assertion failed: " + e.Message);
                    test.Log(Status.Fail, $"Test failed due to: {e.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
        }

        //
        private IWebElement Name => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/enterName"));
        private IWebElement Designation => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/designation"));
        private IWebElement PhoneNo => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/phoneNo"));
        private IWebElement Nationality => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/nationality"));
        private IWebElement Email => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/email"));

    }
}
