using HW18.Factories;
using HW18.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18.Tests
{
    internal class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            BasePage.OpenMainPage();
            Thread.Sleep(5000);
            
        }
        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
        

    }
}
