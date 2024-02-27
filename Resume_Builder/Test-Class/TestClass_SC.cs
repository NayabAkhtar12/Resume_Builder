using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using ResumeBuilder.Core;
using ResumeBuilder.Pages.Create_CV;
using ResumeBuilder.Pages;
using System.Drawing.Drawing2D;

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

        //Object of Pages
        PersonalInfo P;
        Academics A;
        Experience Experience;
        Skills skills;
        Interests Int;
        Achievements Ach;
        References Ref;
        Languages Lang;
        Projects Projects;
        SocialLinks SL;

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

        [TestMethod]
        public void Experiences()
        {
            Experience = new Experience(driver);
            Experience.ValidExperience();
            Experience.InValidExperience();
        }


        [TestMethod]
        public void AddSkills()
        {
            skills = new Skills(driver);
            skills.AddSkills();
            skills.AddInvalidSkills();
            skills.AddSpacesSkills();
        }

        [TestMethod]
        public void Interests()
        {
            Int = new Interests(driver);
            Int.AddInterests();
            Int.AddInvalidInterests();
            Int.AddSpacesinInterests();
        }

        [TestMethod]
        public void Acheivement()
        {
            Ach=new Achievements(driver);
            Ach.AddValidAchievements();
            Ach.AddInValidAchievements();
            Ach.AddSpacesinAchievements();

        }

        [TestMethod]
        public void Languages()
        {
            Lang = new Languages(driver);
            Lang.Language_ValidInput();
            Lang.InvalidLanguages();
            Lang.spacesinLanguages();
        }

        [TestMethod]
        public void References()
        {
            Ref = new References(driver);
            Ref.ValidReferencs();
            Ref.InvalidReferencs();
            Ref.Spaces();
        }

        [TestMethod]
        public void Project()
        {
         //  Proj = new Projects(driver);
            Ref.ValidReferencs();
            Ref.InvalidReferencs();
            Ref.Spaces();
        }
        [TestMethod]
        public void SocialMediaLinks()
        {
            SocialLinks SL = new SocialLinks(driver); // Assuming driver is initialized somewhere
            SL.ValidSocialLinks();
        }
    }
  
}
