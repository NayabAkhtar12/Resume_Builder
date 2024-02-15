using OpenQA.Selenium;
using OpenQA.Selenium.Appium;


namespace ScientificCalculator.Pages
{
    public class ResumeBuilderIds
    {
        private AppiumDriver<IWebElement> driver;

        public ResumeBuilderIds(AppiumDriver<IWebElement> driver)
        {
            this.driver = driver;
        }

        //Identifiers
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
        public IWebElement AddImage => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/addImage"));
        public IWebElement ChooseImage => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/chooseImage"));

        public IWebElement FromGallery => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/chooseImage"));
        public IWebElement Day(string expectedDay)
        {
            return driver.FindElement(By.XPath($"//android.view.View[@content-desc=\"{expectedDay}\"]"));
        }
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
