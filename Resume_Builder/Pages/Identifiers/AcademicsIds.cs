using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Reflection;


namespace ResumeBuilder.Pages
{
    public class AcademicsIds
    {
        private AppiumDriver<IWebElement> driver;

        //public AcademicsIds(AppiumDriver<IWebElement> driver)
        //{
        //    this.driver = driver;
        //}
        private WebDriverWait wait;
        private IWebElement element;

        public AcademicsIds(AppiumDriver<IWebElement> driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(70));
            element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(@"//android.widget.TextView[@resource-id=""com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/textinput_placeholder""]")));
        }
        public IWebElement Ist => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/textinput_placeholder"));

        public IWebElement Major_Course => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/major"));

        public IWebElement Degree => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/course"));
        public IWebElement Start_Date => driver.FindElement(By.XPath(@"//android.view.View[@content-desc=""18 February 2024""]"));
        public IWebElement End_Date => driver.FindElement(By.XPath(@"//android.view.View[@content-desc=""27 February 2024""]"));
        public IWebElement OK => driver.FindElement(By.Id(@"android:id/button1"));
        public IWebElement Cancel => driver.FindElement(By.Id(@"//android.widget.Button[@resource-id=""android:id/button2""]"));
        public IWebElement SaveAndNext => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/save"));
        public IWebElement SDate => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/startDate"));
        public IWebElement EDate => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/endDate"));
        public IWebElement Mobile => driver.FindElement(By.Id("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/textinput_placeholder")); // Update with your actual XPath

    }
}
