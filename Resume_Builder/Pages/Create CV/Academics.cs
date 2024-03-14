using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace ResumeBuilder.Pages.Create_CV
{
    public class Academics
    {
        private AppiumDriver<IWebElement> driver;
        private Actions action;
        private ExtentTest Test;

        public Academics(AppiumDriver<IWebElement> driver, ExtentTest Test)
        {
            this.driver = driver;
            this.Test = Test;
            action = new Actions(driver);
        }

        public void ValidInfo()
        {
            try
            {
                AcademicsMenu.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                MobileElement();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                action.SendKeys("CodersInsignPVT LTD").Perform();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Major_Course.SendKeys("SQA");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Degree.SendKeys("Software Engineering");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                SDate.Click();
                OK.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                EDate.Click();
                OK.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                SaveAndNext.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
        }
        public void InValidInfo_Spaces()
        {
            try
            {
                MobileElement();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while locating MobileElement: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to locate MobileElement. Details: {ex.Message}");
            }

            try
            {
                action.SendKeys("%&*").Perform();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to action: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to action. Details: {ex.Message}");
            }

            try
            {
                Major_Course.SendKeys("  12%^&*");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to Major_Course: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to Major_Course. Details: {ex.Message}");
            }

            try
            {
                Degree.SendKeys("034988547664444444444444");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to Degree: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to Degree. Details: {ex.Message}");
            }

            try
            {
                SDate.Click();
                Start_Date.Click();
                OK.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while handling date fields: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Date fields failed. Details: {ex.Message}");
            }

            try
            {
                EDate.Click();
                End_Date.Click();
                OK.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while handling end date fields: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: End date fields failed. Details: {ex.Message}");
            }

            try
            {
                SaveAndNext.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking SaveAndNext button: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click SaveAndNext button. Details: {ex.Message}");
            }
        }


        public void AcademicInfoSpaces()
        {
            try
            {
                MobileElement();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while locating MobileElement: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to locate MobileElement. Details: {ex.Message}");
            }

            try
            {
                action.SendKeys("             ").Perform();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to action: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to action. Details: {ex.Message}");
            }

            try
            {
                Major_Course.SendKeys("     ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to Major_Course: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to Major_Course. Details: {ex.Message}");
            }

            try
            {
                Degree.SendKeys("    ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while sending keys to Degree: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to send keys to Degree. Details: {ex.Message}");
            }

            try
            {
                SDate.Click();
                Start_Date.Click();
                OK.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while handling date fields: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Date fields failed. Details: {ex.Message}");
            }

            try
            {
                EDate.Click();
                End_Date.Click();
                OK.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while handling end date fields: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: End date fields failed. Details: {ex.Message}");
            }

            try
            {
                SaveAndNext.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking SaveAndNext button: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to click SaveAndNext button. Details: {ex.Message}");
            }
        }

        public void NavigateBack()
        {
            try
            {
                BackButton.Click();

            }
            catch (Exception e)
            {
                Test.Log(Status.Fail, $"Test failed due to: Failed to click Save button. Details: {e.Message}");
            }
        }
        //Identifiers
        private IWebElement AcademicsMenu => driver.FindElementByXPath("//android.widget.GridView[@resource-id=\"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/list_tabs\"]/android.view.ViewGroup[2]");

        private IWebElement BackButton => driver.FindElementByAccessibilityId("Navigate up");
        private IWebElement Discard => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/discard");

        IWebElement Ist => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/textinput_placeholder"));

        IWebElement Major_Course => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/major"));

        IWebElement Degree => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/course"));
        IWebElement Start_Date => driver.FindElement(By.XPath(@"//android.view.View[@content-desc=""18 February 2024""]"));
        IWebElement End_Date => driver.FindElement(By.XPath(@"//android.view.View[@content-desc=""27 February 2024""]"));
        IWebElement OK => driver.FindElement(By.Id(@"android:id/button1"));
        IWebElement Cancel => driver.FindElement(By.Id(@"//android.widget.Button[@resource-id=""android:id/button2""]"));
        IWebElement SaveAndNext => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/save"));
        IWebElement SDate => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/startDate"));
        private IWebElement EDate => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/endDate"));
        private IWebElement Mobile => driver.FindElement(By.Id("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/textinput_placeholder"));

        [Obsolete]
        private void MobileElement()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/institute")));
            element.Click();
        }
    }
}
