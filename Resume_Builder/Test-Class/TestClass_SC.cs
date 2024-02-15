using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using ScientificCalculator.Core;
using ScientificCalculator.Pages;

namespace ScientificCalculator.Test_Class
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

            // Call the test1 method with the expected date and year
            P.test1("Thu 15 Feb", "2024");
        }
    }
}
