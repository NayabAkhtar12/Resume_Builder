using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResumeBuilder.Core;
using ResumeBuilder.Pages;
using ResumeBuilder.Pages.Create_CV;

namespace ResumeBuilder.Test_Class
{
    [TestClass]
    public class TestClass : TestInitialize
    {
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
            ExtentTest test = extent.CreateTest("Personal Information Report");
            P = new PersonalInfo(driver, test);
            P.OpenPersonalInfo();
            P.ImageUploading();
            P.PersonalInfo_Valid();
            P.PersonalInfo_InValid();
            P.PersonalInfo_Spaces();

        }

        [TestMethod]
        public void Acedemics()
        {
            ExtentTest test = extent.CreateTest("Acedemics Information Report");

            A = new Academics(driver, test);
            A.ValidInfo();
            A.InValidInfo_Spaces();
            A.AcademicInfoSpaces();
            A.NavigateBack();
        }

        [TestMethod]
        public void Experiences()
        {
            ExtentTest test = extent.CreateTest("Experiences Information Report");

            Experience = new Experience(driver, test);
            Experience.ValidExperience();
            Experience.InValidExperience();
        }


        [TestMethod]
        public void AddSkills()
        {
            ExtentTest test = extent.CreateTest("Skills Information Report");

            skills = new Skills(driver, test);
            skills.AddValidSkills();
            skills.AddSpacesinSkills();
            skills.AddInvalidSkills();
        }

        [TestMethod]
        public void Interests()
        {
            ExtentTest test = extent.CreateTest("Interests Information Report");

            Int = new Interests(driver, test);
            Int.AddValidInterests();
            Int.AddInvalidInterests();
            Int.AddSpacesinInterests();

        }

        [TestMethod]
        public void Acheivement()
        {
            ExtentTest test = extent.CreateTest("Acheivement Information Report");

            Ach = new Achievements(driver, test);
            Ach.AddValidAchievements();
            Ach.AddSpacesinAchievements();
            Ach.AddInValidAchievements();
        }

        [TestMethod]
        public void Languages()
        {
            ExtentTest test = extent.CreateTest("Languages Information Report");

            Lang = new Languages(driver, test);
            Lang.Language_ValidInput();
            Lang.InvalidLanguages();
            Lang.spacesinLanguages();
        }

        [TestMethod]
        public void References()
        {
            ExtentTest test = extent.CreateTest("References Information Report");

            Ref = new References(driver, test);
            Ref.ValidReferencs();
            Ref.InvalidReferencs();
            Ref.Spaces();
        }

        [TestMethod]
        public void Project()
        {
            ExtentTest test = extent.CreateTest("Project Information Report");

            Projects = new Projects(driver, test);
            Projects.ValidProjects();
            Projects.InValidProjects();
        }

        [TestMethod]
        public void SocialMediaLinks()
        {
            ExtentTest test = extent.CreateTest("SocialMediaLinks Information Report");

            SL = new SocialLinks(driver, test);
            SL.ValidSocialLinks();
        }
    }

}
