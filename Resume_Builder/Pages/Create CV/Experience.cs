using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;


namespace ResumeBuilder.Pages.Create_CV
{
    public class Experience
    {
        private AppiumDriver<IWebElement> driver;
        private ExtentTest Test;

        public Experience(AppiumDriver<IWebElement> driver, ExtentTest Test)
        {
            this.driver = driver;
            this.Test = Test;
        }

        public void ValidExperience()
        {
            try
            {
                ExpMenu.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking on ExpMenu: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click on ExpMenu. Details: {ex.Message}");
            }

            try
            {
                Company.SendKeys("CIT");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to Company: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to Company. Details: {ex.Message}");
            }

            try
            {
                Designation.SendKeys("SQA");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to Designation: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to Designation. Details: {ex.Message}");
            }

            try
            {
                Details.SendKeys("Phase 8");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to Details: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to Details. Details: {ex.Message}");
            }

            try
            {
                Start_DateDield.Click();
                Ok.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while handling start date fields: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to handle start date fields. Details: {ex.Message}");
            }

            try
            {
                EnddateField.Click();
                Ok.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while handling end date fields: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to handle end date fields. Details: {ex.Message}");
            }

            try
            {
                SaveandNext.Click();
                Back.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking SaveandNext or Back button: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click SaveandNext or Back button. Details: {ex.Message}");
            }
        }

        public void InValidExperience()
        {
            try
            {
                Company.SendKeys("%^$$");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to Company: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to Company. Details: {ex.Message}");
            }

            try
            {
                Designation.SendKeys("%$#");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to Designation: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to Designation. Details: {ex.Message}");
            }

            try
            {
                Details.SendKeys("%$#");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to Details: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to Details. Details: {ex.Message}");
            }

            try
            {
                Start_DateDield.Click();
                Star_Date.Click();
                Ok.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while handling start date fields: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to handle start date fields. Details: {ex.Message}");
            }

            try
            {
                EnddateField.Click();
                EndDate.Click();
                Ok.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while handling end date fields: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to handle end date fields. Details: {ex.Message}");
            }

            try
            {
                SaveandNext.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking SaveandNext button: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click SaveandNext button. Details: {ex.Message}");
            }
        }

        public void Spaces()
        {
            try
            {
                Company.SendKeys("       ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to Company: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to Company. Details: {ex.Message}");
            }

            try
            {
                Designation.SendKeys("          ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to Designation: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to Designation. Details: {ex.Message}");
            }

            try
            {
                Details.SendKeys("         ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to Details: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to Details. Details: {ex.Message}");
            }

            try
            {
                Start_DateDield.Click();
                Star_Date.Click();
                Ok.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while handling start date fields: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to handle start date fields. Details: {ex.Message}");
            }

            try
            {
                EnddateField.Click();
                EndDate.Click();
                Ok.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while handling end date fields: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to handle end date fields. Details: {ex.Message}");
            }

            try
            {
                Back.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Back button: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click Back button. Details: {ex.Message}");
            }
        }    

        IWebElement ExpMenu => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/name\" and @text=\"Experiences\"]");
        IWebElement Company => driver.FindElementById ("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/companyName");
        IWebElement Designation => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/designation");
        IWebElement Details => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/didWhat");

        IWebElement Start_DateDield => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/startDate");
        IWebElement EnddateField => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/endDate");
        IWebElement Star_Date => driver.FindElementByAccessibilityId("26 February 2024");
        IWebElement EndDate => driver.FindElementByAccessibilityId("24 February 2024");
        IWebElement Ok=> driver.FindElementById("android:id/button1");
         IWebElement Cancel => driver.FindElementById("android:id/button2");
        IWebElement Back => driver.FindElementByAccessibilityId("Navigate up");
        IWebElement SaveandNext => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/save");

    }
}
