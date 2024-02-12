using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScientificCalculator.Core;
using ScientificCalculator.Pages;

namespace ScientificCalculator.Test_Class

{
    [TestClass]
     public class TestClass_SC : TestInitialize
    {
        Addition Add;
        EMI e;

        [TestMethod, Priority(1)]
        public void test()
        {
            e.EMIWithValidValues();
        }
        //Operations of Scientific Calculator
        //Addition

        [TestMethod, Priority(1)]
            public void Addition()
        {
            Add = new Addition(driver);
            Add.ClearScreen();
            Add.BasicAddition();
            Add.DecimalAddition();
            Add.DecimalIntegerAdd();
            Add.PositiveNegativeAddition();
            Add.NegativeIntegerAddition();
            Add.ZeroAddition();
            Add.AdditionOfNegativeDecimals();
            Add.AdditionOfNegativePositiveDecimals();
            Add.ErrorHandling();
            Add.LargeNumbersAddition();
        }

    }
}
