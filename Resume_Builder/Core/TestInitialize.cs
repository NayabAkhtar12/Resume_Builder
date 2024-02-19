using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using System;


namespace ResumeBuilder.Core
{
    public class TestInitialize
    {

        public AndroidDriver<IWebElement> driver;

        //public TestInitialize(AppiumDriver<IWebElement> driver)
        //{
        //    this.driver = driver;
        //}
        //[TestInitialize]

        //public void Setup()
        //{
        //    AppiumOptions Cap = new AppiumOptions();
        //    Cap.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
        //    Cap.AddAdditionalCapability(MobileCapabilityType.DeviceName, "OPPO A16");
        //    Cap.AddAdditionalCapability(MobileCapabilityType.Udid, "ONOZSG4H8HSGW8HY");
        //    Cap.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "11");
        //    Cap.AddAdditionalCapability("appium:automationName", AutomationName.AndroidUIAutomator2);
        //    Cap.AddAdditionalCapability(AndroidMobileCapabilityType.AppPackage, "com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader");
        //    Cap.AddAdditionalCapability(AndroidMobileCapabilityType.AppActivity, "com.resumemakerapp.cvmaker.Copper.CropImageActivity - CV Maker");
        //    // Use MobileCapabilityType.App for specifying the app path directly
        //    Cap.AddAdditionalCapability(MobileCapabilityType.App, "/data/app/~~YTheRiuzbBCtVzExXoLCnA==/com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader-8ElXVAj5w6cs-EUxBOnyQQ==/base.apk");

        //    //Navigate to App
        //    driver = new AndroidDriver<IWebElement>(new Uri("http://192.168.100.5:4723/"), Cap, TimeSpan.FromSeconds(180));

        //    //  driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        //}
        //s8
        [TestInitialize]

        public void Setup()
        {
            AppiumOptions Cap = new AppiumOptions();
            Cap.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            Cap.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Galaxy s7");
            Cap.AddAdditionalCapability(MobileCapabilityType.Udid, "e7c7d60c");
            Cap.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "8.0.0");
            Cap.AddAdditionalCapability("appium:automationName", AutomationName.AndroidUIAutomator2);
            //    Cap.AddAdditionalCapability(AndroidMobileCapabilityType.AppPackage, "com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader");
            //   Cap.AddAdditionalCapability(AndroidMobileCapabilityType.AppActivity, "com.resumemakerapp.cvmaker.Copper.CropImageActivity - CV Maker");
            // Use MobileCapabilityType.App for specifying the app path directly
            Cap.AddAdditionalCapability("unicodeKeyboard", false);
            Cap.AddAdditionalCapability("resetKeyboard", false);

            //   Cap.AddAdditionalCapability(MobileCapabilityType.App, "/data/app/com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader--MO3PCVgfH7n4Uv5R86seQ==/base.apk");

            // Navigate to App
            driver = new AndroidDriver<IWebElement>(new Uri("http://192.168.100.22:4723/"), Cap, TimeSpan.FromSeconds(180));

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // Code for cleaning up resources, closing the app, etc.
            driver.CloseApp();
            driver.Quit();
        }
    }
}
