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
    public class TestClass_SC : TestInitialize
    {
        //private AppiumDriver<IWebElement> driver;
        //private TestInitialize testInitialize;
        //public TestClass_SC()
        //{
        //    // Initialize TestInitialize class
        //    testInitialize = new TestInitialize();

        //    // Call the Setup method from TestInitialize
        //    testInitialize.Setup();

        //    // Assign the driver instance
        //    driver = testInitialize.GetDriver();
        //}

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

     //   [TestMethod]
        public void PersonalInfo()
        {


        }

        [TestMethod]
        public void Acedemics()
        {
             A = new Academics(driver);
            A.ValidInfo();
          //  A.InValidInfo_Spaces();
           // A.AcademicInfo();
            A.NavigateBack();
        }

        [TestMethod]
        public void Experiences()
        {
            Experience = new Experience(driver);
            Experience.ValidExperience();
         //   Experience.InValidExperience();
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
            Int.AddSpacesinInterests();
            Int.AddInvalidInterests();
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
           Projects = new Projects(driver);
           Projects.ValidProjects();
           Projects.InValidProjects();
        }
        [TestMethod]
        public void SocialMediaLinks()
        {
             SL = new SocialLinks(driver); // Assuming driver is initialized somewhere
            SL.ValidSocialLinks();
        }
    }
  
}
