using HW18.Factories;
using HW18.Pages;
using OpenQA.Selenium;
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
        
        public void CheckBoxes1CheckedBeforeCheck()
        {            
            CheckBoxes.OpenCheckBoxesPage();
            Thread.Sleep(1000);
            bool result = CheckBoxes.CheckBoxChecked(0);
            Assert.IsFalse(result);     
        }

        [Test]

        public void CheckBoxes1CheckAndCHecked()
        { 
            CheckBoxes.OpenCheckBoxesPage();
            CheckBoxes.CheckBoxCheck(0);
            bool result = CheckBoxes.CheckBoxChecked(0);
            Assert.IsTrue(result);        
        }
        [Test]
        public void CheckBoxes2CheckedBeforeCheck() 
        {
            CheckBoxes.OpenCheckBoxesPage();
            Thread.Sleep(1000);
            bool result = CheckBoxes.CheckBoxChecked(1);
            Assert.IsTrue(result);
        }
        [Test]
        public void CheckBoxes2CheckAndCHecked()
        {
            CheckBoxes.OpenCheckBoxesPage();
            CheckBoxes.CheckBoxCheck(1);
            bool result = CheckBoxes.CheckBoxChecked(1);
            Assert.IsFalse(result);
        }

        
    }
}
