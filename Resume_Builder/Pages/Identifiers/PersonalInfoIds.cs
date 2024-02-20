using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ResumeBuilder.Pages
{
    public class PersonalInfoIds
    {
        private AppiumDriver<IWebElement> driver;

        public PersonalInfoIds(AppiumDriver<IWebElement> driver)
        {
            this.driver = driver;
        }

        //Identifiers
        public IWebElement Imaget => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.android.documentsui:id/icon_thumb\"])[3]");

        public IWebElement Image => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.android.documentsui:id/icon_thumb\"])[3]");
        public IWebElement Name => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/enterName"));

        public IWebElement Designation => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/designation"));
        public IWebElement DOB => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/dob"));
        public IWebElement PhoneNo => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/phoneNo"));
        public IWebElement Nationality => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/nationality"));
        public IWebElement Email => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/email"));
        public IWebElement Address => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/address"));
        public IWebElement Male => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/male"));
        public IWebElement Female => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/female"));
        public IWebElement Other => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/other"));
        public IWebElement AddImage => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/chooseImage"));
        public IWebElement ChooseImage => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/chooseImage"));

        public IWebElement FromGallery => driver.FindElement(By.XPath(@"//android.widget.TextView[@text=""From Gallery""]"));
        private readonly TimeSpan timeout = TimeSpan.FromSeconds(10); // Adjust timeout as needed

        public IWebElement GetDayElement(string expectedDay)
        {
            try
            {
                string xpath = $"//android.view.View[@content-desc='{expectedDay}']";
                var wait = new WebDriverWait(driver, timeout);
                return wait.Until(d => d.FindElement(By.XPath(xpath)));

            }
            catch (NoSuchElementException ex)
            {
                // Log the error or handle it according to your test scenario
                Console.WriteLine($"Element with content-desc '{expectedDay}' not found: {ex.Message}");
                throw; // Re-throw the exception to indicate failure
            }
        }

        public IWebElement ClickOnCurrentDay(string currentDay)
        {
            try
            {
                string xpath = $"//android.view.View[@text='{currentDay}']";
                var wait = new WebDriverWait(driver, timeout);
                var currentDayElement = wait.Until(d => d.FindElement(By.XPath(xpath)));
                currentDayElement.Click();
                return currentDayElement;
            }
            catch (NoSuchElementException ex)
            {
                // Log the error or handle it according to your test scenario
                Console.WriteLine($"Element with text '{currentDay}' not found: {ex.Message}");
                throw; // Re-throw the exception to indicate failure
            }
        }
                    public IWebElement test => driver.FindElement(By.XPath("//android.widget.DatePicker/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.TextView"));
      public  IWebElement currentDayMonthElement => driver.FindElement(By.Id("android:id/date_picker_header_date"));

       
        public IWebElement Monthview => driver.FindElement(By.XPath("//android.view.View[@resource-id=\"android:id/month_view\"]"));
        public IWebElement okButton => driver.FindElement(By.XPath("//android.widget.Button[@resource-id='android:id/button1']"));
        public IWebElement NextMonth => driver.FindElement(By.Id("android:id/next"));
        public IWebElement PrevMonth => driver.FindElement(By.Id("android:id/prev"));

        public IWebElement DatePicker => driver.FindElement(By.XPath("//android.widget.DatePicker"));
        public IWebElement HeaderDate => driver.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"android:id/date_picker_header_date\"]"));
        public IWebElement HeaderYear => driver.FindElement(By.Id("android:id/date_picker_header_year"));

        public IWebElement Dayelement => driver.FindElementById("android:id/date_picker_header_date");

     
    }
}
