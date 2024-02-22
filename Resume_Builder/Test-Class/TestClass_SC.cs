using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using ResumeBuilder.Core;
using ResumeBuilder.Pages.Create_CV;
using ResumeBuilder.Pages;

namespace ResumeBuilder.Test_Class
{
    [TestClass]
    public class TestClass_SC
    {
        private AppiumDriver<IWebElement> driver;
        private TestInitialize testInitialize;

        public TestClass_SC()
        {
            // Initialize TestInitialize class
            testInitialize = new TestInitialize();

            // Call the Setup method from TestInitialize
            testInitialize.Setup();

            // Assign the driver instance
            driver = testInitialize.GetDriver();
        }

        PersonalInfo P;
        Academics A;

        [TestMethod]
        public void PersonalInfo()
        {
            // Initialize PersonalInfo with the Appium driver
            P = new PersonalInfo(driver);
           //P.OpenPersonalInfo();
         //  P.ImageUploading();
           P.PersonalInfo_Valid();
           // P.PersonalInfo_InValid();
           // P.PersonalInfo_Spaces();
            P.NavigateBack();
            //P.SelectDateofBirth("15 April 2025"); 
        }


       // [TestMethod]
        public void Acedemics()
        {
            Academics A = new Academics(driver);
            A.ValidInfo();
            A.InValidInfo_Spaces();
            A.AcademicInfo();
            A.NavigateBack();
        }

    }
}
