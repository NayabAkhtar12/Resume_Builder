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
    public class Projects
    {
        private AppiumDriver<IWebElement> driver;
        Actions action;
        public Projects(AppiumDriver<IWebElement> driver)
        {
            this.driver = driver;
            action = new Actions(driver);
        }

        public void ValidProjects()
        {
            ProjectMenu.Click();
            ProjectNameRB();
            action.SendKeys("Resume Builder").Perform();
           // ProjectName.SendKeys("Resume Builder");
            Details.SendKeys("fdd");
            StartDateField.Click();
            Ok.Click();
          //  StartDate.Click();
            EndDateField.Click();
            Ok.Click();
          //  EndDate.Click();
          SaveNext.Click();
            Back.Click();
          
        }
        public void InValidProjects()
        {
            ProjectMenu.Click();
            ProjectNameRB();
            action.SendKeys("Resume Builder").Perform();
            driver.HideKeyboard();

            Details.SendKeys("#$%");
            StartDateField.Click();
            Ok.Click();
            //  StartDate.Click();
            EndDateField.Click();
            Ok.Click();
            //  EndDate.Click();
            SaveNext.Click();
            Back.Click();
        }
        public void Spaces()
        {
            ProjectMenu.Click();
            ProjectName.SendKeys("        ");
            Details.SendKeys("    ");
            StartDateField.Click();
            Ok.Click();
            //  StartDate.Click();
            EndDateField.Click();
            Ok.Click();
            //  EndDate.Click();
            SaveNext.Click();
            Back.Click();
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
