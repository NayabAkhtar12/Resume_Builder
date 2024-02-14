﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        //Methods for Identifiers like click
        public void PersonalInfo_ValidInfo()
        {

            // Assert.IsNotNull(I, "Identifiers instance is not initialized");
            I.Name.SendKeys("Nayab");
            I.Designation.SendKeys("SQA");
            //Date of Birth
            I.DOB.Click();
            I.Day.Click();
            I.okButton.Click();
            I.PhoneNo.SendKeys("034999999999");
            I.Nationality.SendKeys("Pakistan");
            I.Email.SendKeys("nayab@gmail.com");
            I.Address.SendKeys("Bahria Phase 8");
            I.Female.Click();

        }

        public void SelectDateOfBirth(string expectedDay, string expectedMonthYear)
        {
            // Click on the Date of Birth field
            I.DOB.Click();
            string Headerdate = I.HeaderDate.Text;
            string HeaderYear = I.HeaderYear.Text;
            string currentMonthYear = $"{Headerdate} {HeaderYear}"; // Combine header date and year
            string Monthview = I.Monthview.Text;

            while(!(Headerdate.Equals(expectedMonthYear)) && (HeaderYear.Equals(expectedDay)))
                {

                }


            // Parse the expected month and year
            string[] expectedMonthYearParts = expectedMonthYear.Split(' ');
            int expectedMonth = DateTime.ParseExact(expectedMonthYearParts[0], "MMMM", CultureInfo.CurrentCulture).Month;
            int expectedYear = int.Parse(expectedMonthYearParts[1]);

            // Parse the current month and year
            string[] currentMonthYearParts = currentMonthYear.Split(' ');
            int currentMonth = DateTime.ParseExact(currentMonthYearParts[0], "MMMM", CultureInfo.CurrentCulture).Month;
            int currentYear = int.Parse(currentMonthYearParts[1]);

            // While loop to navigate to the desired month and year
            while (true)
            {
                if (currentMonth == expectedMonth && currentYear == expectedYear)
                {
                    // If the current month and year match the expected, select the day and break the loop
                    I.Day.Click();
                    break;
                }
                else if (expectedYear > currentYear || (expectedYear == currentYear && expectedMonth > currentMonth))
                {
                    I.NextMonth.Click();
                }
                else if (expectedYear < currentYear || (expectedYear == currentYear && expectedMonth < currentMonth))
                {
                    I.PrevMonth.Click();
                }

                // Update the current month and year for the next iteration
                Headerdate = I.HeaderDate.Text;
                HeaderYear = I.HeaderYear.Text;
                currentMonthYear = $"{Headerdate} {HeaderYear}";
                currentMonthYearParts = currentMonthYear.Split(' ');
                currentMonth = DateTime.ParseExact(currentMonthYearParts[0], "MMMM", CultureInfo.CurrentCulture).Month;
                currentYear = int.Parse(currentMonthYearParts[1]);
            }

            I.okButton.Click();
        }

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



