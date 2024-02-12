using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using ScientificCalculator.Core;
using ScientificCalculator.Pages.Identifiers;


namespace ScientificCalculator.Pages
{
    //By default Its access modifier is Internal
     class EMI : TestInitialize
    {
        private EMI_Identifiers I;

        public EMI(AppiumDriver<IWebElement> driver) 
        {
            // Initialize I in the constructor
            I = new EMI_Identifiers(driver);
        }

 
         //Methods
        public void EMIWithValidValues()
        {
            //Expected Result
            //Amount: ₹10,000           Monthly Emi= 856
            //Interest: 5 %             Total Interest = 273
            //Period: 12 months         Total Payment: 10,273

            I.LoanAmount.Click();
            I.LoanAmount.SendKeys("10000 ");
            I.Interest.SendKeys("5");
            I.LoanTenure.SendKeys("12");
            I.Calculate.Click();

            var MonthlyEMI = I.MonthlyEMI.Text;
            Assert.AreEqual("856.07", MonthlyEMI, "Incorrect Monthly EMI");

            var TotalInterest = I.TotalInterest.Text;
            Assert.AreEqual("272.9", TotalInterest, "Incorrect Total Interest");

            var TotalPayment = I.TotalPayment.Text;
            Assert.AreEqual("10272.9", TotalPayment, "Incorrect Total Payment");
        }
        public void EMIWithLargeValues()
        {
            //Expected Result
            //Amount: ₹1,000,000         Monthly Emi= 13215
            //Interest: 10 %             Total Interest = 5,85,809
            //Period: 120 months         Total Payment: 15,85,809

            I.Clear.Click();
            I.LoanAmount.SendKeys("1000000 ");
            I.Interest.SendKeys("10");
            I.LoanTenure.SendKeys("120");
            I.Calculate.Click();

            var MonthlyEMI = I.MonthlyEMI.Text;
            Assert.AreEqual("13215.07", MonthlyEMI, "Incorrect Monthly EMI");

            var TotalInterest = I.TotalInterest.Text;
            Assert.AreEqual("585808.84", TotalInterest, "Incorrect Total Interest ");

            var TotalPayment = I.TotalPayment.Text;
            Assert.AreEqual("1585808.84", TotalPayment, "Incorrect Total Payment");


        }
        public void EMIWithNullValues()
        {
            //Expected Result
            //Amount: 0                Error
            //Interest: 0 %            Error
            //Period: 0 months         Error

            I.Clear.Click();
            I.LoanAmount.SendKeys("0 ");
            I.Interest.SendKeys("0");
            I.LoanTenure.SendKeys("0");
            I.Calculate.Click();
            var MonthlyEMI = I.MonthlyEMI.Text;
            Assert.AreEqual("Error", MonthlyEMI, "Incorrect Monthly EMI");

            var TotalInterest = I.TotalInterest.Text;
            Assert.AreEqual("Error", TotalInterest, "Incorrect Total Interest ");

            var TotalPayment = I.TotalPayment.Text;
            Assert.AreEqual("Error", TotalPayment, "Incorrect Total Payment");

            I.Clear.Click();
        }

        public void EMIWithMinimumValues()
        {
            //Expected Result
            //Amount: ₹1                  EMI= 1
            //Interest: 0.1 %             Total Interst = 0
            //Period: 1 month             Total Payment =1

            I.Clear.Click();
            I.LoanAmount.SendKeys("1");
            I.Interest.SendKeys("0.1");
            I.LoanTenure.SendKeys("1");
            I.Calculate.Click();
            var MonthlyEMI = I.MonthlyEMI.Text;
            Assert.AreEqual("Error", MonthlyEMI, "Incorrect Monthly EMI");

            var TotalInterest = I.TotalInterest.Text;
            Assert.AreEqual("Error", TotalInterest, "Incorrect Total Interest ");

            var TotalPayment = I.TotalPayment.Text;
            Assert.AreEqual("Error", TotalPayment, "Incorrect Total Payment");

            I.Clear.Click();
        }
        public void EMIWithInvalidPeriod()
        {
            //Expected Result
            //Amount: ₹15,000
            //Interest: 7 %
            //Period: 0 months
            //Calculate = ErrorContext on Period Field
            I.Clear.Click();
            I.LoanAmount.SendKeys("15000");
            I.Interest.SendKeys("7");
            I.LoanTenure.SendKeys("0");
            I.Calculate.Click();
         
            var TotalPayment = I.TotalPayment.Text;
            Assert.AreEqual("Error", TotalPayment, "Incorrect Total Payment");

            I.Clear.Click();

        }

    }
}
