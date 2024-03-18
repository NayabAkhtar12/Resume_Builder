using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Interactions;
using System;

namespace ResumeBuilder.Pages.CV_Template
{
    public class CV_Templates
    {
        private AppiumDriver<IWebElement> driver;
        private Actions action;
        private ExtentTest Test;

        public CV_Templates(AppiumDriver<IWebElement> driver)
        {
            this.driver = driver;
            action = new Actions(driver);
        }

        public void CVTemplates()
        {
            Templates.Click();
            try
            {
                Template1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                Template2.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                Template3.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                //Horizontol Scrolling
                IWebElement Templat4 = driver.FindElement(MobileBy.AndroidUIAutomator(
        "new UiScrollable(new UiSelector().resourceId(\"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/imageHolder\"))"
        + ".setAsHorizontalList().scrollIntoView(new UiSelector())"));
                Templat4.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Template5.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                Template6.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                //Horizontol Scrolling
                IWebElement Templat7 = driver.FindElement(MobileBy.AndroidUIAutomator(
        "new UiScrollable(new UiSelector().resourceId(\"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/imageHolder\"))"
        + ".setAsHorizontalList().scrollIntoView(new UiSelector())"));
                Templat7.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Template8.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                //Horizontol Scrolling
                IWebElement Templat9 = driver.FindElement(MobileBy.AndroidUIAutomator(
        "new UiScrollable(new UiSelector().resourceId(\"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/imageHolder\"))"
        + ".setAsHorizontalList().scrollIntoView(new UiSelector())"));
                Templat9.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                Template10.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
        }


        //Identifiers
        IWebElement Templates => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/cvTemplate");
        IWebElement Template1 => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/imageHolder\"])[1]");
        IWebElement Template2 => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/imageHolder\"])[2]");
        IWebElement Template3 => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/imageHolder\"])[3]");
        IWebElement Template4 => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/imageHolder\"])[2]");
        IWebElement Template5 => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/imageHolder\"])[3]");
        IWebElement Template6 => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/imageHolder\"])[4]");

        IWebElement Template7 => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/imageHolder\"])[2]");
        IWebElement Template8 => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/imageHolder\"])[3]");
        IWebElement Template9 => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/imageHolder\"])[4]");
        IWebElement Template10 => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/imageHolder\"])[3]");


    }
}
