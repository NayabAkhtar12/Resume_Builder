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

      //  [TestMethod]
       public void Create_Cv()
        {
            P = new PersonalInfo(driver);
            P.PersonalInfo_ValidInfo();
            P.PersonalInfo_InValidInfo();
            P.PersonalInfo_SpacesInfo();

        }
        //EMI e;
        [TestMethod]
        public void Select_Date_Of_Birth()
        {
            // Initialize Appium driver and navigate to the desired screen

            // Initialize DatePickerHelper with the Appium driver
            PersonalInfo datePickerHelper = new PersonalInfo(driver);
            // Select the date of birth (e.g., 15th February 1990)
            datePickerHelper.SelectDateOfBirth("2", "February 2024");

            // Additional assertions or actions if needed
        }
      
    }
}
