using Castle.Components.DictionaryAdapter.Xml;
using Newtonsoft.Json.Schema;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Pages.Create_CV
{
    public class SocialLinks
    {
        private AppiumDriver<IWebElement> driver;
        private Actions action;

        public SocialLinks(AppiumDriver<IWebElement> driver)
        {
            this.driver = driver;
            action = new Actions(driver);

        }

        public void ValidSocialLinks()
        {
            IWebElement listItem = driver.FindElement(MobileBy.AndroidUIAutomator(
   "new UiScrollable(new UiSelector().scrollable(true))" +
   ".scrollIntoView(new UiSelector().text(\"Social Links\"))"));

            // Click on the element
            listItem.Click();
            //SocialLinkMenu.Click();

            LinkedIn();
            action.SendKeys("vv").Perform();

            Githublink();
            action.SendKeys("vv").Perform();

            Twitterlink();
            action.SendKeys("vv").Perform();

            Facebooklink();
            action.SendKeys("vv").Perform();
            Back.Click();

        }
        public void InValidSocialLinks()
        {
            SocialLinkMenu.Click();
            Linked.Click();
            Linked.SendKeys("45656^%$");

            Github.Click();
            Github.SendKeys("3545^%$");

            Twitter.Click();
            Twitter.SendKeys("365^%&%");

            Facebook.Click();
            Facebook.SendKeys("45675$%^");

        }
        //XPath

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
