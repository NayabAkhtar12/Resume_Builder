﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using ResumeBuilder.Core;
using ResumeBuilder.Pages;

namespace ResumeBuilder.Test_Class
{
    [TestClass]
    public class TestClass_SC : TestInitialize
    {
        PersonalInfo P;

        [TestMethod]
        public void Create_Cv()
        {
            // Initialize Appium driver and navigate to the desired screen
            // Assuming driver is initialized in the base class TestInitialize

            // Initialize PersonalInfo with the Appium driver
            P = new PersonalInfo(driver);

            P.SelectDateofBirth("15 April 2025"); 
        }
    }
}
