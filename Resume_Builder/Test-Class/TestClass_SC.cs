using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using ResumeBuilder.Core;
using ResumeBuilder.Pages;
using ResumeBuilder.Pages.Create_CV;

namespace ResumeBuilder.Test_Class
{
    [TestClass]
    public class TestClass_SC : TestInitialize
    {
        PersonalInfo P;
        Academics A;
        [TestMethod]
        public void PersonalInfo()
        {
            // Initialize Appium driver and navigate to the desired screen
            // Assuming driver is initialized in the base class TestInitialize

            // Initialize PersonalInfo with the Appium driver
            P = new PersonalInfo(driver);
            P.ImageUploading("D:\\Automation-Projects\\Resume_Builder\\Resume_Builder\\Pages\\images.jpg");
            //P.SelectDateofBirth("15 April 2025"); 
        }

        //[TestMethod]
        public void Academics()
        { 
            A = new Academics(driver);
            A.ValidInfo();
            A.InValidInfo();
            A.PersonalInfo_SpacesInfo();
        }

    }
}
