﻿
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ResumeBuilder.Core
{
    public class TestInitialize
    {
        private AppiumDriver<IWebElement> driver;

        //Method for accessing the driver outside the class
        public AppiumDriver<IWebElement> GetDriver()
        {
            return driver;
        }
        [TestInitialize]
        public void Setup()
        {
            try
            {
                AppiumOptions options = new AppiumOptions();
                options.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
                options.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Galaxy s7");
                options.AddAdditionalCapability(MobileCapabilityType.Udid, "e7c7d60c");
                options.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "8.0.0");
                options.AddAdditionalCapability("appium:automationName", AutomationName.AndroidUIAutomator2);
                options.AddAdditionalCapability("unicodeKeyboard", false);
                options.AddAdditionalCapability("resetKeyboard", false);

                driver = new AndroidDriver<IWebElement>(new Uri("http://192.168.100.22:4723/"), options, TimeSpan.FromSeconds(180));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
               
            }
            catch (Exception ex)
            {
                // Handle driver initialization failure
                Console.WriteLine($"Failed to initialize driver: {ex.Message}");
                throw;
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (driver != null)
            {
                try
                {
                    driver.CloseApp();
                    driver.Quit();
                }
                catch (Exception ex)
                {
                    // Handle driver cleanup failure
                    Console.WriteLine($"Failed to cleanup driver: {ex.Message}");
                }
            }
        }
    }
}