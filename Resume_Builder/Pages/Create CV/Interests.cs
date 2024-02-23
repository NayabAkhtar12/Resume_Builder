using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Pages.Create_CV
{
    class Interests
    {
        private AppiumDriver<IWebElement> driver;

        public Interests(AppiumDriver<IWebElement> driver)
        {
            this.driver = driver;
        }
        public void AddInterests()
        {
            InterestMenu.Click();
            AddButton.Click();
            AddSkill.SendKeys("Manual Testing");
            BackButton.Click();
            Save.Click();

        }
        //Identifiers
        IWebElement InterestMenu => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/name\" and @text=\"Interest/Hobbies\"]");
        private IWebElement AddButton => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/add_new");
        private IWebElement AddSkill => driver.FindElementByXPath("//android.widget.EditText[@text=\"Add Skills\"]");

        IWebElement BackButton => driver.FindElementByAccessibilityId("Navigate up");

        IWebElement Save => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/save");
        IWebElement Discard => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/discard");

    }
}
