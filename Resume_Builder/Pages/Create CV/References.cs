using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;

namespace ResumeBuilder.Pages.Create_CV
{
    internal class References
    {
        private AppiumDriver<IWebElement> driver;
        private ExtentTest Test;

        public References(AppiumDriver<IWebElement> driver, ExtentTest Test)
        {
            this.driver = driver;
            this.Test = Test;
        }

        public void ValidReferencs()
        {
            try
            {
                ReferMenu.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking on ReferMenu: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click on ReferMenu. Details: {ex.Message}");
            }

            try
            {
                AddReference.SendKeys("Manual Testing");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to AddReference: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to AddReference. Details: {ex.Message}");
            }

        }

        public void InvalidReferencs()
        {
            try
            {
                AddButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking on AddButton: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click on AddButton. Details: {ex.Message}");
            }

            try
            {
                AddReference.SendKeys("$%^^");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to AddReference: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to AddReference. Details: {ex.Message}");
            }
        }

        public void Spaces()
        {
            try
            {
                AddButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking on AddButton: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click on AddButton. Details: {ex.Message}");
            }

            try
            {
                AddReference.SendKeys("    ");
                AddButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to AddReference: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to AddReference. Details: {ex.Message}");
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
        IWebElement ReferMenu => driver.FindElementByXPath("//android.widget.GridView[@resource-id=\"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/list_tabs\"]/android.view.ViewGroup[8]");
        private IWebElement AddButton => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/add_new");
        private IWebElement AddReference => driver.FindElementByXPath("//android.widget.EditText[@text=\"References\"]");

        IWebElement BackButton => driver.FindElementByAccessibilityId("Navigate up");

        IWebElement Save => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/save");
        IWebElement Discard => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/discard");

    }
}
