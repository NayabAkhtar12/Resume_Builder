using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;

namespace ResumeBuilder.Pages.Create_CV
{
    class Skills
    {
        private AppiumDriver<IWebElement> driver;

        private ExtentTest Test;

        public Skills(AppiumDriver<IWebElement> driver, ExtentTest Test)
        {
            this.driver = driver;
            this.Test = Test;
        }

        public void AddValidSkills()
        {
            try
            {
                SkillMenu.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking on SkillMenu: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click on SkillMenu. Details: {ex.Message}");
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
                AddSkill.SendKeys("Manual Testing");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to AddSkill: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to AddSkill. Details: {ex.Message}");
            }

        }

        public void AddInvalidSkills()
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
                AddSkill.SendKeys("%$^&%$");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to AddSkill: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to AddSkill. Details: {ex.Message}");
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

            try
            {
                Save.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking on Save: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click on Save. Details: {ex.Message}");
            }

        }

        public void AddSpacesinSkills()
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
                AddSkill.SendKeys("         ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to AddSkill: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to AddSkill. Details: {ex.Message}");
            }

        }

        //Identifiers
        IWebElement SkillMenu => driver.FindElementByXPath("//android.widget.GridView[@resource-id=\"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/list_tabs\"]/android.view.ViewGroup[4]");
        private IWebElement AddButton => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/add_new");
        private IWebElement AddSkill => driver.FindElementByXPath("//android.widget.EditText[@text=\"Add Skills\"]");

        IWebElement BackButton => driver.FindElementByAccessibilityId("Navigate up");

        IWebElement Save => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/save");
        IWebElement Discard => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/discard");

    }
}
