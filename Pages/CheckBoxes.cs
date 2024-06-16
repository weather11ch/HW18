using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18.Pages
{
    internal class CheckBoxes : BasePage
    {
        private static IWebElement checkBoxess;
       

        public static void OpenCheckBoxes()
        {
            checkBoxess = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"content\"]/ul/li[6]/a")));
            checkBoxess.Click();
        }
    }
}
