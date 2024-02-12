using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using ScientificCalculator.Core;
using System;


namespace ScientificCalculator.Pages
{
    //By default Its access modifier is Internal
     class Addition : TestInitialize
    {
        private ResumeBuilderIds I;

        public Addition(AppiumDriver<IWebElement> driver)
        {
            // Initialize I1 in the constructor
            I = new ResumeBuilderIds(driver);
        }

        public void ClearScreen()
        {
            if (!string.IsNullOrEmpty(I.FinalResult.Text))
            {
                // If not clear, perform the clear operation
                I.ClearScreen.Click();

                // You can add an assertion or print a message to verify the clear operation
                Assert.IsTrue(string.IsNullOrEmpty(I.FinalResult.Text), "Result screen is not cleared after clicking ClearScreen.");

                // Or print a message
                Console.WriteLine("Result screen has been cleared.");
            }
            else
            {
                // The result screen is already clear
                Console.WriteLine("Result screen is already clear.");
            }
        }
        //Methods for Identifiers like click
        public void BasicAddition()
        {
         
           // Assert.IsNotNull(I, "Identifiers instance is not initialized");
            I.Button5.Click();
            I.Plus.Click();
            I.Button3.Click();
            I.Equal.Click();
            var AdditionResult = I.FinalResult.Text;
            Assert.AreEqual("8", AdditionResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        // Addition of Decimals
        public void DecimalAddition()
        {
            // Test Data: 2.5 + 1.5 = 4
            I.Button2.Click();
            I.point.Click();
            I.Button5.Click();
            I.Plus.Click();
            I.Button1.Click();
            I.point.Click();
            I.Button5.Click();
            I.Equal.Click();
            var DecimalAdditionResult = I.FinalResult.Text;
            Assert.AreEqual("4", DecimalAdditionResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        // Addition of Integer and Decimals
        public void DecimalIntegerAdd()
        {
            // Expected Result: 8 + 4.2 = 12.2
            I.Button8.Click();
            I.Plus.Click();
            I.Button4.Click();
            I.point.Click();
            I.Button2.Click();
            I.Equal.Click();
            var DecimalIntegerAdd = I.FinalResult.Text;
            Assert.AreEqual("12.2", DecimalIntegerAdd, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        public void ZeroAddition()
        {
            // Addition of Zero
            // Expected Result: 0 + 10 = 10
            I.zero.Click();
            I.Plus.Click();
            I.Button1.Click();
            I.zero.Click();
            I.Equal.Click();
            var ZeroAdditionResult = I.FinalResult.Text;
            Assert.AreEqual("10", ZeroAdditionResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        // Positive-Negative Addition
        public void PositiveNegativeAddition()
        {
            // Expected Result: 5 + (-3) = 2
            I.Button5.Click();
            I.Plus.Click();
            I.LeftBracket.Click();
            I.Minus.Click();
            I.Button3.Click();
            I.Rightbracket.Click();
            I.Equal.Click();
            var PositiveNegativeAdditionResult = I.FinalResult.Text;
            Assert.AreEqual("2", PositiveNegativeAdditionResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        public void NegativeIntegerAddition()
        {
            // Negative Integer Addition
            // Expected Result: (-4) + (-2) = -6
            I.LeftBracket.Click();
            I.Minus.Click();
            I.Button4.Click();
            I.Rightbracket.Click();
            I.Plus.Click();
            I.LeftBracket.Click();
            I.Minus.Click();
            I.Button2.Click();
            I.Rightbracket.Click();
            I.Equal.Click();
            var NegativeIntegerAddition = I.FinalResult.Text;
            Assert.AreEqual("-6", NegativeIntegerAddition, "Result is not as Expected");
            I.ClearScreen.Click();
        }
        public void AdditionOfNegativeDecimals()
        {
            // Addition of Negative Decimals
            // Expected Result: (-2.5) + (-1.5) = -4
            I.LeftBracket.Click();
            I.Minus.Click();
            I.Button2.Click();
            I.point.Click();
            I.Button5.Click();
            I.Rightbracket.Click();
            I.Plus.Click();
            I.LeftBracket.Click();
            I.Minus.Click();
            I.Button1.Click();
            I.point.Click();
            I.Button5.Click();
            I.Rightbracket.Click();
            I.Equal.Click();
            var NegativeIntegerAddition = I.FinalResult.Text;
            Assert.AreEqual("-4", NegativeIntegerAddition, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        // Addition of Negative positive Decimals
        public void AdditionOfNegativePositiveDecimals()
        {
            // Expected Result: (-7) + 3.5 = -3.5
            I.LeftBracket.Click();
            I.Minus.Click();
            I.Button7.Click();
            I.Rightbracket.Click();
            I.Plus.Click();
            I.Button3.Click();
            I.point.Click();
            I.Button5.Click();
            I.Equal.Click();
            var AdditionOfNegativePositiveDecimals = I.FinalResult.Text;
            Assert.AreEqual("-3.5", AdditionOfNegativePositiveDecimals, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        public void ErrorHandling()
        {
            // Error Handling
            // Expected Result: (-7) + 3.5) = Syntax Error Or Infinity
            I.LeftBracket.Click();
            I.Minus.Click();
            I.Button7.Click();
            I.Rightbracket.Click();
            I.Plus.Click();
            I.Button3.Click();
            I.point.Click();
            I.Button5.Click();
            I.Rightbracket.Click();
            I.Equal.Click();
            var ErrorHandlingResult = I.FinalResult.Text;
            Assert.AreEqual("Syntax Error Or Infinity", ErrorHandlingResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        public void LargeNumbersAddition()
        {
            // Scenario: Handling of large numbers
            // Expected Result: 999999999 + 9999999999 = 10999999998
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Plus.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Equal.Click();
            var LargeNumbersAddition = I.FinalResult.Text;
              Assert.AreEqual("10999999998", LargeNumbersAddition, "Result is not as Expected");
            I.ClearScreen.Click();

        }


    }
    }
