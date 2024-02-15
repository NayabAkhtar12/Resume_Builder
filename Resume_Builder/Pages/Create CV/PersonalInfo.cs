using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Mac;
using OpenQA.Selenium.Support.UI;
using ScientificCalculator.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;


namespace ScientificCalculator.Pages
{
    //By default Its access modifier is Internal
    class PersonalInfo : TestInitialize
    {
        private ResumeBuilderIds I;

        public PersonalInfo(AppiumDriver<IWebElement> driver)
        {
            // Initialize I1 in the constructor
            I = new ResumeBuilderIds(driver);
        }
        private TestInitialize T;

     

        public void PersonalInfo_ValidInfo()
        {
            //Valid Personal Info
            // Assert.IsNotNull(I, "Identifiers instance is not initialized");
            I.Name.SendKeys("Nayab");
            I.Designation.SendKeys("SQA");
            //Date of Birth
            I.DOB.Click();
            //I.Day.Click(); //13 feb
            I.okButton.Click();
            I.PhoneNo.SendKeys("03498854766");
            I.Nationality.SendKeys("Pakistani");
            I.Email.SendKeys("nayabf52@gmail.com");
            I.Address.SendKeys("Bahria Phase 8");
            I.Female.Click();

        }

        public void PersonalInfo_InValidInfo()
        {
            //InValid Personal Info
            // Assert.IsNotNull(I, "Identifiers instance is not initialized");
            I.Name.SendKeys("%&*");
            I.Designation.SendKeys("  12%^&*");
            //Date of Birth
            I.DOB.Click();
           // I.Day.Click(); //13 feb
            I.okButton.Click();
            I.PhoneNo.SendKeys("034988547664444444444444");
            I.Nationality.SendKeys("%^&*");
            I.Email.SendKeys("nayabf52er355");
            I.Address.SendKeys("$%^&%G");
            I.Male.Click();
            I.Female.Click();
        }

        public void PersonalInfo_SpacesInfo()
        {
            //InValid Personal Info
            // Assert.IsNotNull(I, "Identifiers instance is not initialized");
            I.Name.SendKeys("   ");
            I.Designation.SendKeys("     ");
            //Date of Birth
            I.DOB.Click();
           // I.Day.Click(); //13 feb
            I.okButton.Click();
            I.PhoneNo.SendKeys("    ");
            I.Nationality.SendKeys("    ");
            I.Email.SendKeys("   ");
            I.Address.SendKeys("   ");
            I.Male.Click();
            I.Female.Click();
        }

        public void test(string exdate, string exyear )
        {
            // Click on the Date of Birth field
            I.DOB.Click();

            // Get the current header date and year
            string headerDate = I.HeaderDate.Text;
            string headerYear = I.HeaderYear.Text;
            string currentMonthYear = $"{headerDate} {headerYear}"; // Combine header date and year

            while (!(headerDate.Equals(exdate)) && (headerYear.Equals(exyear)))
            {
                // Navigate to next month
                I.NextMonth.Click();
                break;
            }
        }
        public void test1(string exdate, string exyear)
        {
            // Click on the Date of Birth field
            I.DOB.Click();

            // Get the current header date and year
            string headerDate = I.HeaderDate.Text;
            string headerYear = I.HeaderYear.Text;
            string currentMonthYear = $"{headerDate} {headerYear}"; // Combine header date and year

            // Define a regular expression pattern to match the month
            string[] dateParts = headerDate.Split(' ');

            // Use Regex.Match to find the first occurrence of the month in the header date
            string month = dateParts[dateParts.Length - 1];


            // Parse the expected month and year
            string[] expectedDateParts = exdate.Split(' ');
            string expectedMonth = expectedDateParts[2];
            string exday = expectedDateParts[1];

            int expectedYear = int.Parse(exyear);
            if (expectedYear == int.Parse(headerYear) && (expectedMonth == month))
            {
                // Find and click on the day element
                I.Day(exday).Click();
                I.okButton.Click();
            }
            // Compare the current month and year with the expected
            while (!(headerDate.Equals(exdate) && headerYear.Equals(exyear)))
            {
                if (expectedYear == int.Parse(headerYear) && string.Compare(expectedMonth, month, StringComparison.CurrentCultureIgnoreCase) < 0)
                {
                    I.Day(exday).Click();
                    I.okButton.Click();
                    break;
                }
                // If expected year is greater than current year or if expected month is greater than current month
                else if (expectedYear > int.Parse(headerYear) || string.Compare(expectedMonth, headerDate, StringComparison.CurrentCultureIgnoreCase) > 0)
                {
                    // Navigate to next month
                    I.NextMonth.Click();
                    I.Day(exday).Click();

            break;
                }
                else if (expectedYear < int.Parse(headerYear) || string.Compare(expectedMonth, headerDate, StringComparison.CurrentCultureIgnoreCase) > 0)

                {
                    // Navigate to previous month
                    I.PrevMonth.Click();
                    // Construct XPath for the expected day
                    string dayXPath = $"//android.view.View[@content-desc=\"{exday}\"]";
                    // Find and click on the day element
                    driver.FindElement(By.XPath(dayXPath)).Click();
                    I.okButton.Click();
                    break; 
                }

                else
                {
                  
                    break;
                }

                // Update the current header date and year
                headerDate = I.HeaderDate.Text;
                headerYear = I.HeaderYear.Text;
            }
        }


        //public void SelectDateOfBirth(string expectedDay, string expectedMonthYear)
        //    {
        //        // Click on the Date of Birth field
        //        I.DOB.Click();

        //        // Get the current header date and year
        //        string headerDate = I.HeaderDate.Text;
        //        string headerYear = I.HeaderYear.Text;
        //        string currentMonthYear = $"{headerDate} {headerYear}"; // Combine header date and year

        //        // Parse the expected month and year
        //        string[] expectedMonthYearParts = expectedMonthYear.Split(' ');
        //        int expectedMonth = DateTime.ParseExact(expectedMonthYearParts[0], "MMMM", CultureInfo.CurrentCulture).Month;
        //        int expectedYear = int.Parse(expectedMonthYearParts[1]);

        //        // Parse the current month and year
        //        string[] currentMonthYearParts = currentMonthYear.Split(' ');
        //        int currentMonth = DateTime.ParseExact(currentMonthYearParts[0], "MMMM", CultureInfo.CurrentCulture).Month;
        //        int currentYear = int.Parse(currentMonthYearParts[1]);

        //        // While loop to navigate to the desired month and year
        //        while (currentMonth != expectedMonth || currentYear != expectedYear)
        //        {
        //            if (currentYear < expectedYear || (currentYear == expectedYear && currentMonth < expectedMonth))
        //            {
        //                // Navigate to next month
        //                I.NextMonth.Click();
        //            }
        //            else if (currentYear > expectedYear || (currentYear == expectedYear && currentMonth > expectedMonth))
        //            {
        //                // Navigate to previous month
        //                I.PrevMonth.Click();
        //            }

        //            // Update the current month and year for the next iteration
        //            headerDate = I.HeaderDate.Text;
        //            headerYear = I.HeaderYear.Text;
        //            currentMonthYear = $"{headerDate} {headerYear}";
        //            currentMonthYearParts = currentMonthYear.Split(' ');
        //            currentMonth = DateTime.ParseExact(currentMonthYearParts[0], "MMMM", CultureInfo.CurrentCulture).Month;
        //            currentYear = int.Parse(currentMonthYearParts[1]);
        //        }

        //    // Select the expected day
        //    I.Day(exday).Click();

        //    // Click the OK button to confirm the selected date
        //    I.okButton.Click();
        //    }


            //while (true)
            //{
            //    // Find the month and year header

            //    string calendarMonthYear = I.HeaderDate.Text;

            //    if (calendarMonthYear.Equals(expectedMonthYear))
            //    {
            //        // Find and click on the expected day
            //        try
            //        {
            //            driver.FindElementByXPath($"//android.view.View[@text='{expectedDay}']").Click();
            //            break;
            //        }

            //        catch (NoSuchElementException)
            //        {
            //            // Handle the case when the expected day is not found
            //            Console.WriteLine($"Day {expectedDay} not found for the selected month and year.");
            //            break;
            //        }
            //    }
            //    else
            //    {
            //        // Navigate to the next month
            //        I.NextMonth.Click();
            //    }
            //}
        }




    }



