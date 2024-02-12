using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScientificCalculator.Core;
using ScientificCalculator.Pages;

namespace ScientificCalculator.Test_Class
{
    [TestClass]
    public class TestClass_EMI:  TestInitialize
    {
        EMI E;
        [TestMethod]
      public void EMI()
        {
            E = new EMI(driver);

            E.EMIWithValidValues();

            E.EMIWithLargeValues();

            E.EMIWithNullValues();

            E.EMIWithMinimumValues();

            E.EMIWithInvalidPeriod();
        }
    }
}
