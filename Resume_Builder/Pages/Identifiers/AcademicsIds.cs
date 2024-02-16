using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ResumeBuilder.Pages
{
    public class AcademicsIds
    {
        private AppiumDriver<IWebElement> driver;

        public AcademicsIds(AppiumDriver<IWebElement> driver)
        {
            this.driver = driver;
        }

        //Identifiers
        public IWebElement Institute => driver.FindElement(By.XPath(@"//android.widget.EditText[@resource-id=""com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/institute"" and @text=""fhuf""]"));

        public IWebElement Major_Course => driver.FindElement(By.Id(@"//android.widget.EditText[@resource-id=""com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/major"" and @text=""djdj""]"));

        public IWebElement Degree => driver.FindElement(By.Id(@"//android.widget.EditText[@resource-id=""com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/course"" and @text=""idid""]"));
        public IWebElement Start_Date => driver.FindElement(By.Id(@" "));
        public IWebElement End_Date => driver.FindElement(By.Id(@" "));

    }
}
