using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Pages.Create_CV
{
    public class Projects
    {
        private AppiumDriver<IWebElement> driver;
        public Projects(AppiumDriver<IWebElement> driver)
        {
            this.driver = driver;
        }

        public void ValidProjects()
        {
            ProjectMenu.Click();
            ProjectName.SendKeys("Resume Builder");
            StartDateField.Click();
            StartDate.Click();
            EndDateField.Click();
            EndDate.Click();
        }
        
        //Identifiers
        IWebElement ProjectMenu => driver.FindElementByAccessibilityId("");
        IWebElement ProjectName => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/textinput_placeholder");
        IWebElement StartDateField => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/startDate");
        IWebElement StartDate => driver.FindElementById("");

        IWebElement EndDateField => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/endDate");
        IWebElement EndDate => driver.FindElementById("");


    }
}
