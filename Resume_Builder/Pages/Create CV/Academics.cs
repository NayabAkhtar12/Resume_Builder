using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Interactions;
using ResumeBuilder.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace ResumeBuilder.Pages.Create_CV
{
    public class Academics :TestInitialize
    {
        private AcademicsIds I;
        private Actions action; // Declare Actions object at the class level

        public Academics(AppiumDriver<IWebElement> driver) 
        {
            I = new AcademicsIds(driver);
           action = new Actions(driver);

        }
        public void ValidInfo()
        {
            //Valid  Info
         
            I.Mobile.Click();
            // Send keys "hop" using the Actions class
            action.SendKeys("CodersInsignPVT LTD").Perform();
          //  action.MoveToElement(I.SaveAndNext).Click().Perform();
         // driver.HideKeyboard();
            I.Major_Course.SendKeys("SQA");
            //Date of Birth
            I.Degree.SendKeys("Software Engineering");
            I.SDate.Click();
          I.Start_Date.Click(); //13 feb
            I.OK.Click();
            I.EDate.Click();
            I.End_Date.Click(); //13 feb
            I.OK.Click();
            I.SaveAndNext.Click();

        }

        public void InValidInfo()
        {
            //InValid  Info
            I.Mobile.Click();
            // Send keys "hop" using the Actions class
            action.SendKeys("%&*").Perform();
            I.Major_Course.SendKeys("  12%^&*");
            I.Degree.SendKeys("034988547664444444444444");
            I.SDate.Click();
            I.Start_Date.Click(); //13 feb
            I.OK.Click();
            I.EDate.Click();
            I.End_Date.Click(); //13 feb
            I.OK.Click();
            I.SaveAndNext.Click();
        }

        public void PersonalInfo_SpacesInfo()
        {
            //InValid Personal Info
            I.Mobile.Click();
            // Send keys "hop" using the Actions class
            action.SendKeys("             ").Perform();
            I.Major_Course.SendKeys("     ");  
            I.Degree.SendKeys("    ");
            I.SDate.Click();
            I.Start_Date.Click(); //13 feb
            I.OK.Click();
            I.EDate.Click();
            I.End_Date.Click(); //13 feb
            I.OK.Click();
            I.SaveAndNext.Click();
        }

    }
}
