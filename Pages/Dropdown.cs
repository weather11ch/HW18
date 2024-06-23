using HW18.Factories;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace HW18.Pages
{
    internal class Dropdown : BasePage
    {
        public static IWebElement dropdown;
        public static IWebElement selectOption;
        public static IWebElement option1;
        public static IWebElement option2;
        

        public static void OpenDropdownPage()
        {
            
            dropdown = Driver.WaitDriver(driver, 30).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"content\"]/ul/li[11]/a")));
            dropdown.Click();
        }

        public static bool OptionCheckSelected(string optionNumber)
        {            
            string attr1 = option1.GetAttribute("value");
            string attr2 = option1.GetAttribute("selected");
            bool check;
            if (attr1 == optionNumber & attr2 == "true")
            {
                check = true;
            }
            else check = false;
            return check;
        }

        public static void SelectOption()
        {
            selectOption = Driver.GetDriver().FindElement(By.XPath("//*[@id='dropdown']"));
            selectOption.Click();
        }

        public static void SelectOption1()
        {
            option1 = Driver.GetDriver().FindElement(By.XPath("//*[@id='dropdown']/option[2]"));
            option1.Click();
        }
        public static void SelectOption2()
        {
            option1 = Driver.GetDriver().FindElement(By.XPath("//*[@id='dropdown']/option[3]"));
            option1.Click();
        }


    }
}
