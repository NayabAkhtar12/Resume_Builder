using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Pages.Create_CV
{
    class Skills
    {
        private AppiumDriver<IWebElement> driver;

       public Skills(AppiumDriver<IWebElement> driver) 
        { 
        this.driver= driver;
        }
        public void AddSkills()
        {
            SkillMenu.Click();
            AddButton.Click();
            AddSkill.SendKeys("Manual Testing");
            BackButton.Click();
            Save.Click();

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
