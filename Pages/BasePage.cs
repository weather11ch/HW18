using HW18.Factories;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace HW18.Pages
{
    internal class BasePage
    {
        protected static IWebDriver driver = Driver.GetDriver();
        protected static WebDriverWait wait = Driver.WaitDriver(driver, 30);


        public static void OpenMainPage()
        {
            driver = Driver.GetDriver();
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");

            driver.Manage().Window.Maximize();
        }
    }
}
