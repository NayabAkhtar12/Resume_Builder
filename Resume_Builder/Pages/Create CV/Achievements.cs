using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Pages.Create_CV
{
     class Achievements
    {
        private AppiumDriver<IWebElement> driver;

        public Achievements(AppiumDriver<IWebElement> driver)
        {
            this.driver = driver;
        }
        public void AddValidAchievements()
        {
            AchievementMenu.Click();
            AddButton.Click();
            AddAchvmnt.SendKeys("Certificationa");
            BackButton.Click();
            Save.Click();

        }
        public void AddInValidAchievements()
        {
            AchievementMenu.Click();
            AddButton.Click();
            AddAchvmnt.SendKeys("#$%^");
            BackButton.Click();
            Save.Click();

        }

        public void AddSpacesinAchievements()
        {
            AchievementMenu.Click();
            AddButton.Click();
            AddAchvmnt.SendKeys("#$%^");
            BackButton.Click();
            Save.Click();

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
