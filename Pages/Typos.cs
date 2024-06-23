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
    internal class Typos : BasePage
    {
        public static IWebElement typos;
        public static IWebElement textValue;
        public static void OpenPageTypos()
        {
            typos = Driver.WaitDriver(driver, 30).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"content\"]/ul/li[43]/a")));
            typos.Click();
        }
        public static void CheckPageTypos() 
        {
            //textValue = Driver.GetDriver().FindElement(By.TagName("p"));
            textValue = Driver.GetDriver().FindElement(By.XPath("/*[@id=\"content\"]/div/p[1]/text()"));

           string text = textValue.Text;
            string text1 = textValue.GetAttribute("value");


        }
    }
}

//*[@id="content"]/div/p[1]/text()
//*[@id="content"]/div/p[1]/text()
//*[@id="content"]/div/p[2]