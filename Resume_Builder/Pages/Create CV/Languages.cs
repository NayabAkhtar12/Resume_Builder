using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;

namespace ResumeBuilder.Pages.Create_CV
{
     class Languages
    {
        private AppiumDriver<IWebElement> driver;
        private ExtentTest Test;
        public Languages(AppiumDriver<IWebElement> driver, ExtentTest Test)
        {
            this.driver = driver;
            this.Test = Test;
        }

        public void Language_ValidInput()
        {
            try
            {
                LanguagesMenu.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking on LanguagesMenu: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click on LanguagesMenu. Details: {ex.Message}");
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

            try
            {
                AddLanguages.SendKeys("English");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to AddLanguages: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to AddLanguages. Details: {ex.Message}");
            }

        }

        public void spacesinLanguages()
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
                AddLanguages.SendKeys("            ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to AddLanguages: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to AddLanguages. Details: {ex.Message}");
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

        public void InvalidLanguages()
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
                AddLanguages.SendKeys("#$%^");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to AddLanguages: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to AddLanguages. Details: {ex.Message}");
            }
        }



        //Identifiers
        IWebElement LanguagesMenu => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/name\" and @text=\"Languages\"]");
        private IWebElement AddButton => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/add_new");
        private IWebElement AddLanguages => driver.FindElementByXPath("//android.widget.EditText[@text=\"Languages\"]");

        IWebElement BackButton => driver.FindElementByAccessibilityId("Navigate up");

        IWebElement Save => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/save");
        IWebElement Discard => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/discard");

    }
}
