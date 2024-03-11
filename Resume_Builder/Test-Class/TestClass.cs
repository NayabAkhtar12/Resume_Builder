using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using ResumeBuilder.Core;
using ResumeBuilder.Pages.Create_CV;
using ResumeBuilder.Pages;
using AventStack.ExtentReports;
using System;

namespace ResumeBuilder.Test_Class
{
    [TestClass]
    public class TestClass : TestInitialize1
    {
     //   public TestClass() : base() { }

        [TestMethod]
        public void ExTest()
        {
            ExtentTest test = extent.CreateTest("PersonalInformationReport");

            ExTest exTest = new ExTest(driver, test);
            exTest.PersonalInfo_InValid();

        }
    }
}
