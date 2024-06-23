using HW18.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18.Tests
{
    internal class InputsTests : BaseTest
    {
        [Test]
        public void InputsKeyArrowUpTest()
        {
            Inputs.OpenPageInputs();
            Inputs.InputKeyArrowUp(1);
            bool result = Inputs.CheckInputValue("1");
            Assert.IsTrue(result,"Key ArrowUp checked");

        }
        [Test]
        public void InputNumberValueTest()
        {
            Inputs.OpenPageInputs();
            Inputs.InputValue("1223");
            bool result = Inputs.CheckInputValue("1223");
            Assert.IsTrue(result, "Input number value checked");
        }
        [Test]
        public void InputStringValueTest()
        {
            Inputs.OpenPageInputs();
            Inputs.InputValue("1223");
            bool result = Inputs.CheckInputValue("test");
            Assert.IsFalse(result, "Input string value checked");
        }
        [Test] 
        public void InputsKeyArrowDownTest()
        {
            Inputs.OpenPageInputs();
            Inputs.InputKeyArrowUp(2);
            Inputs.InputKeyArrowDown(1);
            bool result = Inputs.CheckInputValue("1");
            Assert.IsTrue(result, "Key ArrowDown checked");
        }

    }
}
