using HW18.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18.Tests
{
    internal class TyposTests : BaseTest
    {
        [Test]
        public void TyposTest()
        {
            Typos.OpenPageTypos();
            Thread.Sleep(1000);
            Typos.CheckPageTypos();
        }
    }
}
