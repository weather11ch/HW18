﻿using HW18.Factories;
using HW18.Pages;


namespace HW18.Tests
{
    internal class AddRemoveElementsTests : BaseTest
    {
        [Test]
        public void AddRemoveElementsTest()
        {
            AddRemoveElements.OpenAddRemoveElements();
            AddRemoveElements.AddElement();
            AddRemoveElements.AddElement();
            AddRemoveElements.DeleteElementButton();
            int count = AddRemoveElements.CountElementsDelete();
            Assert.That(count.Equals(1));
        }
        [Test]
        public void AddRemoveElementsTestAdd()
        {
            AddRemoveElements.OpenAddRemoveElements();
            AddRemoveElements.AddElement();
            AddRemoveElements.AddElement();
            int count = AddRemoveElements.CountElementsDelete();
            Assert.That(count.Equals(2));
        }
        
    }
}
