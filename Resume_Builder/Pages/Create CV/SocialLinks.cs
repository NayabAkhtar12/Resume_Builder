
using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace ResumeBuilder.Pages.Create_CV
{
    public class SocialLinks
    {
        private AppiumDriver<IWebElement> driver;
        private Actions action;

        private ExtentTest Test;

        public SocialLinks(AppiumDriver<IWebElement> driver, ExtentTest Test)
        {
            this.driver = driver;
            this.Test = Test;
            action = new Actions(driver);

        }

        public void ValidSocialLinks()
        {
            try
            {
                IWebElement listItem = driver.FindElement(MobileBy.AndroidUIAutomator(
                    "new UiScrollable(new UiSelector().scrollable(true))" +
                    ".scrollIntoView(new UiSelector().text(\"Social Links\"))"));

                // Click on the element
                listItem.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while scrolling to Social Links: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to scroll to Social Links. Details: {ex.Message}");
            }

            try
            {
                LinkedIn();
                action.SendKeys("vv").Perform();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while entering LinkedIn link: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to enter LinkedIn link. Details: {ex.Message}");
            }

            try
            {
                Githublink();
                action.SendKeys("vv").Perform();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while entering Github link: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to enter Github link. Details: {ex.Message}");
            }

            try
            {
                Twitterlink();
                action.SendKeys("vv").Perform();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while entering Twitter link: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to enter Twitter link. Details: {ex.Message}");
            }

            try
            {
                Facebooklink();
                action.SendKeys("vv").Perform();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while entering Facebook link: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to enter Facebook link. Details: {ex.Message}");
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

        public void InValidSocialLinks()
        {
            try
            {
                SocialLinkMenu.Click();
                Linked.Click();
                Linked.SendKeys("45656^%$");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while entering invalid LinkedIn link: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to enter invalid LinkedIn link. Details: {ex.Message}");
            }

            try
            {
                Github.Click();
                Github.SendKeys("3545^%$");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while entering invalid Github link: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to enter invalid Github link. Details: {ex.Message}");
            }

            try
            {
                Twitter.Click();
                Twitter.SendKeys("365^%&%");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while entering invalid Twitter link: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to enter invalid Twitter link. Details: {ex.Message}");
            }

            try
            {
                Facebook.Click();
                Facebook.SendKeys("45675$%^");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while entering invalid Facebook link: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: Failed to enter invalid Facebook link. Details: {ex.Message}");
            }
        }


        IWebElement Linked => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/textinput_placeholder");
        IWebElement Github => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/github");
        IWebElement Twitter => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/twitter");
        IWebElement Facebook => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/facebook");
        IWebElement Back => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/top_bar");
        IWebElement SocialLinkMenu => driver.FindElementByXPath("//android.widget.GridView[@resource-id=\"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/list_tabs\"]/android.view.ViewGroup[10]");

        private void LinkedIn()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element=wait.Until(ExpectedConditions.ElementIsVisible(By.Id("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/textinput_placeholder")));
            element.Click();
        }
        private void Githublink()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/github")));
            element.Click();
        }

        private void Twitterlink()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/twitter")));
            element.Click();
        }

        private void Facebooklink()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/facebook")));
            element.Click();
        }
    }
}
