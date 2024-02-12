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
        public IWebElement Male => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/seven"));
        public IWebElement Female => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/eight"));
        public IWebElement Other => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine"));
        public IWebElement UploadImage => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/addImage"));
        public IWebElement ChooseImage => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/chooseImage"));

    }
}
