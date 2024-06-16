using HW18.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18.Tests
{
    internal class CheckBoxesTest : BaseTest
    {
        [Test]
        public void CheckBoxesTests()
        {
            CheckBoxes.OpenCheckBoxes();
            Thread.Sleep(1000);
        }
    }
}
