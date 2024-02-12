using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScientificCalculator.Core;
using ScientificCalculator.Pages;

namespace ScientificCalculator.Test_Class

{
    [TestClass]
     public class TestClass_SC : TestInitialize
    {
        Addition Add;
     
       public void Create_Cv()
        {
            Add = new Addition(driver);
            Add.PersonalInfo_ValidInfo();
        }
        //EMI e;
        [TestMethod]
        public void Select_Date_Of_Birth()
        {
            // Initialize Appium driver and navigate to the desired screen

            // Initialize DatePickerHelper with the Appium driver
            Addition datePickerHelper = new Addition(driver);

            // Select the date of birth (e.g., 15th February 1990)
            datePickerHelper.SelectDateOfBirth(15, 2, 1990);

            // Additional assertions or actions if needed
        }
    }
}
