using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Mac;
using OpenQA.Selenium.Support.UI;
using ResumeBuilder.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;


namespace ResumeBuilder.Pages
{
    //By default Its access modifier is Internal
    class PersonalInfo : TestInitialize
    {
        private PersonalInfoIds I;

        public PersonalInfo(AppiumDriver<IWebElement> driver)
        {
            // Initialize I1 in the constructor
            I = new PersonalInfoIds(driver);
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

        public void SelectDateofBirth(string exdate)
        {
            // Click on the Date of Birth field
            I.DOB.Click();

            // Get the current header date and year
            string headerDate = I.HeaderDate.Text;
            string CYear = I.HeaderYear.Text;
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

            string month= I.Monthview.Text;
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
            string str=I.currentDayMonthElement.Text;
            //Navigate to the expected month and year
                while (!(cmonth.Equals(exmonthAbbreviation) && CYear.Equals(exyear)))
            {
                I.NextMonth.Click();
                I.ClickOnCurrentDay(cday);
                cmonth = I.HeaderDate.Text.Split(' ')[1]; // Update cmonth with the new month
                CYear = I.HeaderYear.Text;
            }

            // Click on the expected day element
            I.GetDayElement(exdate).Click();
            I.okButton.Click();
        }
    }
}



