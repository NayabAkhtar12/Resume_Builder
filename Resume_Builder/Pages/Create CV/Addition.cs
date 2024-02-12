using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Mac;
using ScientificCalculator.Core;
using System;
using System.Drawing;


namespace ScientificCalculator.Pages
{
    //By default Its access modifier is Internal
     class Addition : TestInitialize
    {
        private ResumeBuilderIds I;

        public Addition(AppiumDriver<IWebElement> driver)
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
            I.PhoneNo.SendKeys("034999999999");
            I.Nationality.SendKeys("Pakistan");
            I.Email.SendKeys("nayab@gmail.com");
            I.Address.SendKeys("Bahria Phase 8");
            I.Male.Click();
            
        }

        public void SelectDateOfBirth(int v1, int v2, int v3)
        {
            I.DOB.Click();
            // Tap on the month view to open the calendar
         //   I.Month.Click();

            // Tap on the specific day
            I.Day.Click();

            // Tap on the OK button
            I.okButton.Click();
        }
    }
    }
