using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;
using ResumeBuilder.Core;
using System;
using System.Collections.Generic;

namespace ResumeBuilder.Pages
{
    //By default Its access modifier is Internal
    class PersonalInfo 
    {
        private AppiumDriver<IWebElement> driver;

        //private PersonalInfoIds I;

        public PersonalInfo(AppiumDriver<IWebElement> driver)
        {
            // Initialize I1 in the constructor
            // I = new PersonalInfoIds(driver);
            this.driver = driver;
        }

        public void ImageUploading(string imageName)
        {
            // Scroll until the desired image is visible
            ScrollToImage(imageName);

            // Find the image element by its resource ID or other attributes
            IWebElement imageElement = driver.FindElement(By.XPath($"//android.widget.ImageView[@content-desc='{imageName}']"));

            // Click on the image to select it
            imageElement.Click();
        }
        private void ScrollToImage(string imageName)
        {
            // Perform scrolling until the desired image is in view
            // Example: Scroll horizontally until the image is found
            TouchAction touchAction = new TouchAction(driver);
            touchAction.Press(100, 500). // Initial touch location
                        Wait(500). // Wait for 500 milliseconds
                        MoveTo(900, 500). // Move horizontally
                        Release(). // Release touch
                        Perform();
        }
        //public void ImageUploading(string img)
        //{
        //    I.AddImage.Click();
        //    I.FromGallery.Click();
        //    //Select an Image

        //    I.Image.Click();

        //}
        public void PersonalInfo_Valid()
        {
            //Valid Personal Info
            // Assert.IsNotNull(I, "Identifiers instance is not initialized");
            Name.SendKeys("NayabAkhtar");
            Designation.SendKeys("SQA");
            //Date of Birth
            DOB.Click();
            //I.Day.Click(); //13 feb
            okButton.Click();
            PhoneNo.SendKeys("03498854766");
            Nationality.SendKeys("Pakistani");
            Email.SendKeys("nayabf52@gmail.com");
            Address.SendKeys("Bahria Phase 8");
            Female.Click();

        }

        public void PersonalInfo_InValid()
        {
            //InValid Personal Info
            // Assert.IsNotNull(I, "Identifiers instance is not initialized");
            Name.SendKeys("%&*");
            Designation.SendKeys("  12%^&*");
            //Date of Birth
            DOB.Click();
            // I.Day.Click(); //13 feb
            okButton.Click();
            PhoneNo.SendKeys("034988547664444444444444");
            Nationality.SendKeys("%^&*");
            Email.SendKeys("nayabf52er355");
            Address.SendKeys("$%^&%G");
            Male.Click();
            Female.Click();
        }

        public void PersonalInfo_Spaces()
        {
            //InValid Personal Info
            // Assert.IsNotNull(I, "Identifiers instance is not initialized");
            Name.SendKeys("   ");
            Designation.SendKeys("     ");
            //Date of Birth
            DOB.Click();
            // I.Day.Click(); //13 feb
            okButton.Click();
            PhoneNo.SendKeys("    ");
            Nationality.SendKeys("    ");
            Email.SendKeys("   ");
            Address.SendKeys("   ");
            Male.Click();
            Female.Click();
        }

        public void SelectDateofBirth(string exdate)
        {
            // Click on the Date of Birth field
            DOB.Click();

            // Get the current header date and year
            string headerDate = HeaderDate.Text;
            string CYear = HeaderYear.Text;
            string currentMonthYear = $"{headerDate} {CYear}"; // Combine header date and year

            // Define a regular expression pattern to match the month
            string[] CdateParts = headerDate.Split(' ');
            string cday = CdateParts[0];       // Day as a string
            string cmonth = CdateParts[1];     // Month as a string                                  

            // Extract day, month, and year from the expected date
            string[] expectedDateParts = exdate.Split(' ');
            string exday = expectedDateParts[0];       // Day as a string
            string exmonth = expectedDateParts[1]; // same as expected month
            string exyear = expectedDateParts[2];      // Year as a string

            string month = Monthview.Text;
            // Mapping of abbreviated month names to full month names
            Dictionary<string, string> monthMapping = new Dictionary<string, string>
    {
        {"January", "Jan"},
        {"February", "Feb"},
        {"March" , "Mar"},
        {"April" , "Apr"},
        {"May", "May"},
        {"June" , "Jun"},
        {"July" , "Jul"},
        {"August" , "Aug"},
        {"September" , "Sep"},
        {"October" , "Oct"},
        {"November" , "Nov"},
        {"December" , "Dec"}
    };

            // Convert the abbreviated month to full month name
            string exmonthAbbreviation = monthMapping[exmonth];  //I want to store feb here
            //I.test.Click();
            string str = currentDayMonthElement.Text;
            //Navigate to the expected month and year
            while (!(cmonth.Equals(exmonthAbbreviation) && CYear.Equals(exyear)))
            {
                NextMonth.Click();
               ClickOnCurrentDay(cday);
                cmonth = HeaderDate.Text.Split(' ')[1]; // Update cmonth with the new month
                CYear = HeaderYear.Text;
            }

            // Click on the expected day element
            GetDayElement(exdate).Click();
            okButton.Click();
        }

        //Identifiers:

        private IWebElement Imaget => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.android.documentsui:id/icon_thumb\"])[3]");
        private IWebElement Image => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.android.documentsui:id/icon_thumb\"])[3]");
        private IWebElement Name => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/enterName"));
        private IWebElement Designation => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/designation"));
        private IWebElement DOB => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/dob"));
        private IWebElement PhoneNo => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/phoneNo"));
        private IWebElement Nationality => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/nationality"));
        private IWebElement Email => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/email"));
        private IWebElement Address => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/address"));
        private IWebElement Male => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/male"));
        private IWebElement Female => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/female"));
        private IWebElement Other => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/other"));
        private IWebElement AddImage => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/chooseImage"));
        private IWebElement ChooseImage => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/chooseImage"));
        private IWebElement FromGallery => driver.FindElement(By.XPath(@"//android.widget.TextView[@text=""From Gallery""]"));
        private readonly TimeSpan timeout = TimeSpan.FromSeconds(10); // Adjust timeout as needed
        private IWebElement test => driver.FindElement(By.XPath("//android.widget.DatePicker/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.TextView"));
        private IWebElement currentDayMonthElement => driver.FindElement(By.Id("android:id/date_picker_header_date"));
        private IWebElement Monthview => driver.FindElement(By.XPath("//android.view.View[@resource-id=\"android:id/month_view\"]"));
        private IWebElement okButton => driver.FindElement(By.XPath("//android.widget.Button[@resource-id='android:id/button1']"));
        private IWebElement NextMonth => driver.FindElement(By.Id("android:id/next"));
        private IWebElement PrevMonth => driver.FindElement(By.Id("android:id/prev"));
        private IWebElement DatePicker => driver.FindElement(By.XPath("//android.widget.DatePicker"));
        private IWebElement HeaderDate => driver.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"android:id/date_picker_header_date\"]"));
        private IWebElement HeaderYear => driver.FindElement(By.Id("android:id/date_picker_header_year"));
        private IWebElement Dayelement => driver.FindElementById("android:id/date_picker_header_date");
        private IWebElement GetDayElement(string expectedDay)
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

        private IWebElement ClickOnCurrentDay(string currentDay)
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



    }
}



