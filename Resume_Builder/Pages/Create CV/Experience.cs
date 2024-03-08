using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Pages.Create_CV
{
    public class Experience
    {
        private AppiumDriver<IWebElement> driver;
       // private Actions Action;

       public Experience(AppiumDriver<IWebElement> driver)
        {
            this.driver = driver;
           // Action = new Actions(driver);
        }
        public void ValidExperience()
        {
            ExpMenu.Click();
            Company.SendKeys("CIT");
            Designation.SendKeys("SQA");
            Details.SendKeys("Phase 8");
            Start_DateDield.Click();
           // Star_Date.Click();
            Ok.Click();
            EnddateField.Click();
          //  EndDate.Click();
            Ok.Click();
              SaveandNext.Click();
            Back.Click();
        }
        public void InValidExperience()
        {
           // ExpMenu.Click();
            Company.SendKeys("%^$$");
            Designation.SendKeys("%$#");
            Details.SendKeys("%$#");
            Start_DateDield.Click();
            Star_Date.Click();
            Ok.Click();
            EnddateField.Click();
            EndDate.Click();
            Ok.Click();
            SaveandNext.Click();
        }
        public void Spaces()
        {
           // ExpMenu.Click();
            Company.SendKeys("       ");
            Designation.SendKeys("          ");
            Details.SendKeys("         ");
            Start_DateDield.Click();
            Star_Date.Click();
            Ok.Click();
            EnddateField.Click();
            EndDate.Click();
            Ok.Click();
            Back.Click();
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

       // private void MobileElement
    }
}
