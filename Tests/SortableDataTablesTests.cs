using HW18.Pages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18.Tests
{
    internal class SortableDataTablesTests : BaseTest
    {
        [Test]
        public void SortableDataTablesTestFirst()
        {
            SortableDataTables.OpenPageTables();
            bool result = SortableDataTables.CheckDataTables("Smith",1,1);
            Assert.IsTrue(result, "checked first row first column");
        }
        [Test]
        public void SortableDataTablesTestSecond()
        {
            SortableDataTables.OpenPageTables();
            bool result = SortableDataTables.CheckDataTables("Frank", 2, 2);
            Assert.IsTrue(result, "checked second row second column");
        }
        [Test]
        public void SortableDataTablesTestThird()
        {
            SortableDataTables.OpenPageTables();
            bool result = SortableDataTables.CheckDataTables("jdoe@hotmail.com", 3, 3);
            Assert.IsTrue(result, "checked Third row Third column");
        }
        [Test]
        public void SortableDataTablesTestForth()
        {
            SortableDataTables.OpenPageTables();
            bool result = SortableDataTables.CheckDataTables("$50.00", 4, 4);
            Assert.IsTrue(result, "checked Forth row Forth column");
        }
    }
}
