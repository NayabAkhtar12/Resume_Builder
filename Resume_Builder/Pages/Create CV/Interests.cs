using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using System;
using AventStack.ExtentReports;

namespace ResumeBuilder.Pages.Create_CV
{
    class Interests
    {
        private AppiumDriver<IWebElement> driver;

        private ExtentTest Test;

        public Interests(AppiumDriver<IWebElement> driver, ExtentTest Test)
        {
            this.driver = driver;
            this.Test = Test;
        }

        public void AddValidInterests()
        {
            try
            {
                InterestMenu.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking on InterestMenu: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click on InterestMenu. Details: {ex.Message}");
            }
            try
            {
                AddInterest.SendKeys("Walking");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to AddInterest: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to AddInterest. Details: {ex.Message}");
            }
            try
            {
                AddButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking on AddButton: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click on AddButton. Details: {ex.Message}");
            }
        }

        public void AddInvalidInterests()
        {

            try
            {
                AddInterest.SendKeys("#$%^");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to AddInterest: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to AddInterest. Details: {ex.Message}");
            }
            try
            {
                AddButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking on AddButton: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click on AddButton. Details: {ex.Message}");
            }

        }

        public void AddSpacesinInterests()
        {
            try
            {
                AddInterest.SendKeys("          ");
                AddButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to AddInterest: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to AddInterest. Details: {ex.Message}");
            }
            try
            {
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking on BackButton: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click on BackButton. Details: {ex.Message}");
            }
        }

      
        //Identifiers
        IWebElement InterestMenu => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/name\" and @text=\"Interest/Hobbies\"]");
        private IWebElement AddButton => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/add_new");
        private IWebElement AddInterest => driver.FindElementByXPath("//android.widget.EditText[@resource-id=\"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/interests\"]");

        IWebElement BackButton => driver.FindElementByAccessibilityId("Navigate up");

        IWebElement Save => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/save");
        IWebElement Discard => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/discard");

    }
}
