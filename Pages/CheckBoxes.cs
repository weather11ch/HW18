using HW18.Factories;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
        public static IWebDriver driver = Driver.GetDriver();
        public static WebDriverWait wait = Driver.WaitDriver(driver, 30);
        public static IWebElement checkBoxess;        
        public static List<IWebElement> checkBoxes = new List<IWebElement>();
        public static List<string> text = new List<string>();
        

        public static void OpenCheckBoxesPage()
        {
            Driver.GetDriver();
            Driver.WaitDriver(Driver.GetDriver(), 30);

            //checkBoxess = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"content\"]/ul/li[6]/a")));
            checkBoxess = driver.FindElement(By.XPath("//*[@id=\"content\"]/ul/li[6]/a"));
            checkBoxess.Click();
        }
               
        public static bool CheckBoxChecked(int k)
        {
            checkBoxes.Clear();
            checkBoxes = new List<IWebElement>();
            checkBoxes = driver.FindElements(By.CssSelector("[type='checkbox']")).ToList();
            string attr = checkBoxes[k].GetAttribute("checked");
            bool check;
            if (attr == "true") 
            {
                check = true;
            } else check = false;
            return check;
        }

        public static void CheckBoxCheck(int k)
        {
            checkBoxes.Clear();
            checkBoxes = new List<IWebElement>();
            checkBoxes = driver.FindElements(By.CssSelector("[type='checkbox']")).ToList();
            checkBoxes[k].Click();
        }

    }
}
