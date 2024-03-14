using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;

namespace ResumeBuilder.Pages.Create_CV
{
    class Achievements
    {
        private AppiumDriver<IWebElement> driver;

        private ExtentTest Test;

        public Achievements(AppiumDriver<IWebElement> driver, ExtentTest Test)
        {
            this.driver = driver;
            this.Test = Test;
        }

        public void AddValidAchievements()
        {
            try
            {
                AchievementMenu.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking on AchievementMenu: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click on AchievementMenu. Details: {ex.Message}");
            }



            try
            {
                AddAchvmnt.Click();
                AddAchvmnt.SendKeys("Certificationa");
                driver.HideKeyboard();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to AddAchvmnt: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to AddAchvmnt. Details: {ex.Message}");
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


        public void AddInValidAchievements()
        {
            try
            {
                AchievementMenu.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking on AchievementMenu: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click on AchievementMenu. Details: {ex.Message}");
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
                AddAchvmnt.SendKeys("#$%^");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to AddAchvmnt: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to AddAchvmnt. Details: {ex.Message}");
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

        public void AddSpacesinAchievements()
        {
            try
            {
                AddAchvmnt.SendKeys("        ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to AddAchvmnt: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to AddAchvmnt. Details: {ex.Message}");
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

        //Identifiers
        IWebElement AchievementMenu => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/name\" and @text=\"Achievements\"]");
        private IWebElement AddButton => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/add_new");
        private IWebElement AddAchvmnt => driver.FindElementByXPath("//android.widget.EditText[@text=\"Achievements\"]");

        IWebElement BackButton => driver.FindElementByAccessibilityId("Navigate up");

        IWebElement Save => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/save");
        IWebElement Discard => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/discard");

    }
}
