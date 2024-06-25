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
        public static List<IWebElement> text = new List<IWebElement>();
        public static List<string> textValueP = new List<string>();
        public static void OpenPageTypos()
        {
            typos = Driver.WaitDriver(driver, 30).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"content\"]/ul/li[43]/a")));
            typos.Click();
        }
        public static void CheckPageTypos() 
        {            
            text.Clear();
            text = new List<IWebElement>();
            text = Driver.GetDriver().FindElements(By.TagName("p")).ToList();
            List<string> textValueP = new List<string>();
            
            for (int i = 0; i < text.Count; i++)
            {
                textValueP.Add(text[i].Text);                
            }

        }
        public static void OpenPageOrpho()
        {
            Driver.GetDriver().Navigate().GoToUrl("https://www.reverso.net/");
                        
        }
    }
}

//*[@id="content"]/div/p[1]/text()
//*[@id="content"]/div/p[1]/text()
//*[@id="content"]/div/p[2]