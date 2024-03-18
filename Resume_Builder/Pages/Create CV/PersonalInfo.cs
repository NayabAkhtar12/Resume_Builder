using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace ResumeBuilder.Pages
{
    class PersonalInfo
    {
        private AppiumDriver<IWebElement> driver;
        private ExtentTest Test;

        public PersonalInfo(AppiumDriver<IWebElement> driver, ExtentTest Test)
        {
            this.driver = driver;
            this.Test = Test;
        }

        public void OpenPersonalInfo()
        {
            try
            {
                CreateCV.Click();
                //  AdClose.Click();
                Personal_Info.Click();
            }
            catch (Exception e)
            {
                Test.Log(Status.Fail, $"Test failed due to: {e.Message}");
            }

        }
        public void ImageUploading()
        {
            try
            {
                AddImage.Click();
                FromGallery.Click();

                // Scroll to the desired image
                ScrollToImage();

                // Click on the image
                Image.Click();
            }
            catch (Exception e)
            {
                Test.Log(Status.Fail, $"Test failed due to: {e.Message}");

            }

        }

        public void PersonalInfo_InValid()
        {
            try
            {
                try
                {
                    Name.SendKeys("Nayab Akhtar");
                    Assert.IsTrue(Name.Text.Equals("Nayab Akhtar"), "Failed Test Case");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Assertion failed: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    Designation.SendKeys("  12%^&*");
                    Assert.IsTrue(Designation.Text.Equals("SQA"), "Failed Test Case");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Assertion failed: " + e.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {e.Message}");
                }

                try
                {
                    DOB.Click();
                    // I.Day.Click(); 
                    okButton.Click();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception occurred: " + e.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {e.Message}");
                }

                try
                {
                    PhoneNo.SendKeys("034988547664444444444444");
                    Assert.IsTrue(PhoneNo.Text.Equals("03578823844"), "Failed Test Case");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Assertion failed: " + e.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {e.Message}");
                }

                try
                {
                    Nationality.SendKeys("%^&*");
                    Assert.IsTrue(Nationality.Text.Equals("Pakistani"), "Failed Test Case");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Assertion failed: " + e.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {e.Message}");
                }

                try
                {
                    Email.SendKeys("nayabf52er355");
                    Assert.IsTrue(Email.Text.Equals("nayab@gmail.com"), "Failed Test Case");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Assertion failed: " + e.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {e.Message}");
                }
                try
                {
                    Address.SendKeys("$%^&%G");
                    Assert.IsTrue(Address.Text.Equals("Rawalpindi"), "Failed Test Case");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Assertion failed: " + e.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {e.Message}");
                }

                try
                {
                    Female.Click();
                    Assert.IsTrue(Female.Text.Equals("Female"), "Failed Test Case");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Assertion failed: " + e.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {e.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
        }

        public void PersonalInfo_Valid()
        {
            try
            {
                //Valid Personal Info
                Name.SendKeys("NayabAkhtar");
                Assert.IsTrue(Name.Text.Equals("NayabAkhtar"), "Failed Test Case");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Assertion failed: " + ex.Message);
                Test.Log(Status.Fail, $"Name Test failed due to: {ex.Message}");
            }

            try
            {
                Designation.SendKeys("SQA");
                Assert.IsTrue(Designation.Text.Equals("SQA"), " Failed Test Case");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Assertion failed: " + ex.Message);
                Test.Log(Status.Fail, $"Designation Test failed due to: {ex.Message}");
            }

            try
            {
                //Date of Birth
                DOB.Click();
                //I.Day.Click();
                okButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Date Test failed due to: {ex.Message}");
            }

            try
            {
                PhoneNo.SendKeys("03498854766");
                Assert.IsTrue(PhoneNo.Text.Equals("03498854766"), "Failed Test Case");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Assertion failed: " + ex.Message);
                Test.Log(Status.Fail, $" Phone Number Test failed due to: {ex.Message}");
            }

            try
            {
                Nationality.SendKeys("Pakistani");
                Assert.IsTrue(Nationality.Text.Equals("Pakistani"), "Failed Test Case");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Assertion failed: " + ex.Message);
                Test.Log(Status.Fail, $"Nationality Test failed due to: {ex.Message}");
            }

            try
            {
                Email.SendKeys("nayabf52@gmail.com");
                Assert.IsTrue(Email.Text.Equals("nayabf52@gmail.com"), "Failed Test Case");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Assertion failed: " + ex.Message);
                Test.Log(Status.Fail, $"Email Test failed due to: {ex.Message}");
            }

            try
            {
                IWebElement AddressItem = driver.FindElement(MobileBy.AndroidUIAutomator(
                "new UiScrollable(new UiSelector().scrollable(true))" +
                ".scrollIntoView(new UiSelector().text(\"Address*\"))"));
                Address.SendKeys("Bahria Phase 8");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Address Test failed due to: {ex.Message}");
            }

            try
            {
                Female.Click();
                Assert.IsTrue(Female.Text.Equals("Female"), "Failed Test Case");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Assertion failed: " + ex.Message);
                Test.Log(Status.Fail, $"Female Test failed due to: {ex.Message}");
            }


        }

        public void PersonalInfo_Spaces()
        {
            //InValid Personal Info
            try
            {
                Name.SendKeys("   ");
                Assert.IsTrue(Name.Text.Equals("   "), "Failed Test Case");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Assertion failed: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Designation.SendKeys("     ");
                Assert.IsTrue(Designation.Text.Equals("     "), "Failed Test Case");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Assertion failed: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                //Date of Birth
                DOB.Click();
                // I.Day.Click(); //13 feb
                okButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                PhoneNo.SendKeys("    ");
                Assert.IsTrue(PhoneNo.Text.Equals("    "), "Failed Test Case");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Assertion failed: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Nationality.SendKeys("    ");
                Assert.IsTrue(Nationality.Text.Equals("    "), "Failed Test Case");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Assertion failed: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Email.SendKeys("   ");
                Assert.IsTrue(Email.Text.Equals("   "), "Failed Test Case");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Assertion failed: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Address.SendKeys("   ");
                Assert.IsTrue(Address.Text.Equals("   "), "Failed Test Case");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Assertion failed: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Female.Click();
                Assert.IsTrue(Female.Text.Equals("Female"), "Failed Test Case");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Assertion failed: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

        }
        private void ScrollToImage()
        {
            // Scroll until the image becomes visible
            while (!IsImageVisible())
            {
                // Scroll down by swiping up
                SwipeUp();
            }
        }

        private bool IsImageVisible()
        {
            // Check if the image element is visible on the screen
            try
            {
                return Image.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private void SwipeUp()
        {
            // Perform a swipe up gesture to scroll down
            int startX = driver.Manage().Window.Size.Width / 2;
            int startY = (int)(driver.Manage().Window.Size.Height * 0.8);  // Start swipe from 80% of the screen height
            int endY = (int)(driver.Manage().Window.Size.Height * 0.2);    // Swipe up to 20% of the screen height

            TouchAction swipeAction = new TouchAction(driver);
            swipeAction
                .Press(x: startX, y: startY)
                .MoveTo(x: startX, y: endY)
                .Release()
                .Perform();
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

        public void NavigateBack()
        {
            try
            {
                BackButton.Click();
                Save.Click();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception Occured due to {e} ");
            }

        }

        //Identifiers:. 
        IWebElement AdClose => driver.FindElementByXPath("//android.view.View[@resource-id=\"mys-content\"]/android.view.View[2]/android.widget.TextView");
        IWebElement CreateCV => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/createCv");
        IWebElement Personal_Info => driver.FindElementByXPath("//android.widget.GridView[@resource-id=\"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/list_tabs\"]/android.view.ViewGroup[1]");
        private IWebElement Save => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/save");
        private IWebElement Discard => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/discard");

        private IWebElement BackButton => driver.FindElementByAccessibilityId("Navigate up");
        private IWebElement Image => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"android:id/title\" and @text=\"Screenshot_20240109-151655_One UI Home.jpg\"]");
        private IWebElement Imaget => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.android.documentsui:id/icon_thumb\"])[3]");
        private IWebElement Name => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/enterName"));
        private IWebElement Designation => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/designation"));
        private IWebElement DOB => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/dob"));
        private IWebElement PhoneNo => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/phoneNo"));
        private IWebElement Nationality => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/nationality"));
        private IWebElement Email => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/email"));
        private IWebElement Address => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/address"));
        private IWebElement Male => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/male"));
        private IWebElement Female => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/female");
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



