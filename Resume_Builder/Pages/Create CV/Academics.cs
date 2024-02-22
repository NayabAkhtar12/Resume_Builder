using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace ResumeBuilder.Pages.Create_CV
{
    public class Academics 
    {
        // private AcademicsIds I;
        private AppiumDriver<IWebElement> driver;
        private Actions action; 

        public Academics(AppiumDriver<IWebElement> driver) 
        {
            this.driver = driver;
            action = new Actions(driver);

        }
        public void ValidInfo()
        {
            //Valid  Info
            MobileElement();
            // Send keys "hop" using the Actions class
            action.SendKeys("CodersInsignPVT LTD").Perform();
          //  action.MoveToElement(I.SaveAndNext).Click().Perform();
         // driver.HideKeyboard();
            Major_Course.SendKeys("SQA");
            //Date of Birth
            Degree.SendKeys("Software Engineering");
            SDate.Click();
            Start_Date.Click(); //13 feb
            OK.Click();
            EDate.Click();
            End_Date.Click(); //13 feb
            OK.Click();
            SaveAndNext.Click();

        }

        public void InValidInfo_Spaces()
        {
            //InValid  Info
            MobileElement();
            // Send keys "hop" using the Actions class
            action.SendKeys("%&*").Perform();
            Major_Course.SendKeys("  12%^&*");
            Degree.SendKeys("034988547664444444444444");
            SDate.Click();
            Start_Date.Click(); //13 feb
            OK.Click();
            EDate.Click();
            End_Date.Click(); //13 feb
            OK.Click();
            SaveAndNext.Click();
        }

        public void AcademicInfo()
        {
            //InValid Personal Info
            MobileElement();
            // Send keys "hop" using the Actions class
            action.SendKeys("             ").Perform();
            Major_Course.SendKeys("     ");  
            Degree.SendKeys("    ");
            SDate.Click();
            Start_Date.Click(); //13 feb
            OK.Click();
            EDate.Click();
            End_Date.Click(); //13 feb
            OK.Click();
            SaveAndNext.Click();
        }

        public void NavigateBack()
        {
            BackButton.Click();
        }
        //Identifiers
        private IWebElement BackButton => driver.FindElementByAccessibilityId("Navigate up");
        private IWebElement Discard => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/discard");

        IWebElement Ist => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/textinput_placeholder"));

         IWebElement Major_Course => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/major"));

         IWebElement Degree => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/course"));
         IWebElement Start_Date => driver.FindElement(By.XPath(@"//android.view.View[@content-desc=""18 February 2024""]"));
         IWebElement End_Date => driver.FindElement(By.XPath(@"//android.view.View[@content-desc=""27 February 2024""]"));
         IWebElement OK => driver.FindElement(By.Id(@"android:id/button1"));
         IWebElement Cancel => driver.FindElement(By.Id(@"//android.widget.Button[@resource-id=""android:id/button2""]"));
         IWebElement SaveAndNext => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/save"));
         IWebElement SDate => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/startDate"));
        private IWebElement EDate => driver.FindElement(By.Id(@"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/endDate"));
       private IWebElement Mobile => driver.FindElement(By.Id("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/textinput_placeholder"));


        private void MobileElement()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/institute")));
            element.Click();
        }
    }
}
