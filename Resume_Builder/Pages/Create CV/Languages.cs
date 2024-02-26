﻿using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Pages.Create_CV
{
     class Languages
    {
        private AppiumDriver<IWebElement> driver;

        public Languages(AppiumDriver<IWebElement> driver)
        {
            this.driver = driver;
        }
        public void Language_ValidInput()
        {
            LanguagesMenu.Click();
            AddButton.Click();
            AddLanguages.SendKeys("English");
            BackButton.Click();
           // Save.Click();

        }

        public void InvalidLanguages()
        {
            LanguagesMenu.Click();
            AddButton.Click();
            AddLanguages.SendKeys("#$%^");
            BackButton.Click();
           // Save.Click();

        }

        public void spacesinLanguages()
        {
            LanguagesMenu.Click();
            AddButton.Click();
            AddLanguages.SendKeys("            ");
            BackButton.Click();
         //   Save.Click();

        }
        //Identifiers
        IWebElement LanguagesMenu => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/name\" and @text=\"Languages\"]");
        private IWebElement AddButton => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/add_new");
        private IWebElement AddLanguages => driver.FindElementByXPath("//android.widget.EditText[@text=\"Languages\"]");

        IWebElement BackButton => driver.FindElementByAccessibilityId("Navigate up");

        IWebElement Save => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/save");
        IWebElement Discard => driver.FindElementById("com.resumecvbuilder.cvbuilderfree.cvmakerlatest.newcvtemplate.cveditorpdfreader:id/discard");

    }
}