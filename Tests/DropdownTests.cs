using HW18.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18.Tests
{
    internal class DropdownTests : BaseTest
    {
        [Test]
        public void SelectedOption1()
        {
            Dropdown.OpenDropdownPage();
            Thread.Sleep(3000);
            Dropdown.SelectOption();
            Dropdown.SelectOption1();

            bool result = Dropdown.OptionCheckSelected("1");
            Assert.IsTrue(result);
        }

        [Test]
        public void SelectedOption2()
        {
            Dropdown.OpenDropdownPage();
            Thread.Sleep(3000);
            Dropdown.SelectOption();
            Dropdown.SelectOption2();

            bool result = Dropdown.OptionCheckSelected("2");
            Assert.IsTrue(result);
        }
    }
}
