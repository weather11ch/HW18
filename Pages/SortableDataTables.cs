using HW18.Factories;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18.Pages
{
    internal class SortableDataTables : BasePage
    {
        public static IWebElement sortable;
        public static IWebElement cellValue;
        public static void OpenPageTables()
        {
            sortable = Driver.WaitDriver(driver, 30).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"content\"]/ul/li[41]/a")));
            sortable.Click();
        }

        public static bool CheckDataTables(string checkValue, int rowNumber, int columnNumber)
        {
            cellValue = Driver.GetDriver().FindElement(By.XPath("//table//tr[" + rowNumber +"]//td[" + columnNumber +"]"));
            string cellValueText = cellValue.Text;  
            bool check = false;
            if (cellValueText == checkValue) 
            {
                check = true;
            }
            return check;
        }
    }

}
