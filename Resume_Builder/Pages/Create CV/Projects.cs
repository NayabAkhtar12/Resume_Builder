using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace ResumeBuilder.Pages.Create_CV
{
    public class Projects
    {
        private AppiumDriver<IWebElement> driver;
        Actions action;
        private ExtentTest Test;

        public Projects(AppiumDriver<IWebElement> driver, ExtentTest Test)
        {
            this.driver = driver;
            this.Test = Test;
            action = new Actions(driver);

        }

        public void ValidProjects()
        {
            try
            {
                ProjectMenu.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking on ProjectMenu: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click on ProjectMenu. Details: {ex.Message}");
            }

            try
            {
                ProjectNameRB();
                action.SendKeys("Resume Builder").Perform();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to ProjectNameRB: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to ProjectNameRB. Details: {ex.Message}");
            }

            try
            {
                Details.SendKeys("fdd");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to Details: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to Details. Details: {ex.Message}");
            }

            try
            {
                StartDateField.Click();
                Ok.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking on StartDateField or Ok: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click on StartDateField or Ok. Details: {ex.Message}");
            }

            try
            {
                EndDateField.Click();
                Ok.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking on EndDateField or Ok: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click on EndDateField or Ok. Details: {ex.Message}");
            }

            try
            {
                SaveNext.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking on SaveNext: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click on SaveNext. Details: {ex.Message}");
            }
        }

        public void InValidProjects()
        {

            try
            {
                ProjectNameRB();
                action.SendKeys("Resume Builder").Perform();
                driver.HideKeyboard();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to ProjectNameRB: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to ProjectNameRB. Details: {ex.Message}");
            }

            try
            {
                Details.SendKeys("#$%");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to Details: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to Details. Details: {ex.Message}");
            }

            try
            {
                StartDateField.Click();
                Ok.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking on StartDateField or Ok: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click on StartDateField or Ok. Details: {ex.Message}");
            }

            try
            {
                EndDateField.Click();
                Ok.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking on EndDateField or Ok: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click on EndDateField or Ok. Details: {ex.Message}");
            }

            try
            {
                SaveNext.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking on SaveNext: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click on SaveNext. Details: {ex.Message}");
            }
        }

        public void Spaces()
        {
            try
            {
                Details.SendKeys("    ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to Details: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to Details. Details: {ex.Message}");
            }

            try
            {
                StartDateField.Click();
                Ok.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking on StartDateField or Ok: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click on StartDateField or Ok. Details: {ex.Message}");
            }

            try
            {
                EndDateField.Click();
                Ok.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking on EndDateField or Ok: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click on EndDateField or Ok. Details: {ex.Message}");
            }

            try
            {
                SaveNext.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking on SaveNext: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click on SaveNext. Details: {ex.Message}");
            }

            try
            {
                Back.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking on Back: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click on Back. Details: {ex.Message}");
            }
        }

        //Identifiers
        IWebElement ProjectMenu => driver.FindElementByXPath("//android.widget.GridView[@resource-id=\"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/list_tabs\"]/android.view.ViewGroup[9]");
        IWebElement ProjectName => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/textinput_placeholder");
        IWebElement Ok => driver.FindElementById("android:id/button1");
        IWebElement Back => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/top_bar");

        IWebElement cancel => driver.FindElementById("android:id/button2");
        IWebElement SaveNext => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/save");

        IWebElement Details => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/details");

        IWebElement StartDateField => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/startDate");
        IWebElement StartDate => driver.FindElementById("");

        IWebElement EndDateField => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/endDate");
        IWebElement EndDate => driver.FindElementById("");

        private void ProjectNameRB()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/textinput_placeholder")));
            element.Click();
        }
    }
}
