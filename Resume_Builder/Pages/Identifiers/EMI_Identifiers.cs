using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace ScientificCalculator.Pages.Identifiers
{  
        public class EMI_Identifiers
        {
            private AppiumDriver<IWebElement> driver;

            public EMI_Identifiers(AppiumDriver<IWebElement> driver)
            {
                this.driver = driver;
            }

        public IWebElement LoanAmount => driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/loan_amount"));
        public IWebElement Interest => driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/loan_interest"));
        public IWebElement LoanTenure => driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/loan_tenure"));
        public IWebElement Calculate => driver.FindElement(By.XPath("//android.widget.TextView[@text=\"Calculate\"]"));
        public IWebElement Clear => driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/btnClear"));
        public IWebElement MonthlyEMI => driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/emi"));
        public IWebElement TotalInterest => driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/totalIntrestTv"));
        public IWebElement TotalPayment => driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/totalAmountTv"));

    }
}
