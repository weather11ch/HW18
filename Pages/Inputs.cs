using HW18.Factories;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;


namespace HW18.Pages
{
    internal class Inputs : BasePage
    {
        public static IWebElement inputs;
        public static IWebElement inputValue;
        public static void OpenPageInputs()
        {
            inputs = Driver.WaitDriver(driver, 30).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"content\"]/ul/li[27]/a")));
            inputs.Click();
        }
        public static void InputKeyArrowUp(int k)
        {
            inputValue = Driver.WaitDriver(driver, 30).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"content\"]/div/div/div/input")));
            inputValue.Click();
            for (int i = 0; i < k; i++)
            {
                inputValue.SendKeys(Keys.ArrowUp);
            }            
            
        }
        public static void InputKeyArrowDown(int k)
        {
            inputValue = Driver.WaitDriver(driver, 30).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"content\"]/div/div/div/input")));
            inputValue.Click();
            for (int i = 0; i < k; i++)
            {
                inputValue.SendKeys(Keys.ArrowDown);
            }
        }

        public static void InputValue(string value)
        {
            inputValue = Driver.WaitDriver(driver, 30).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"content\"]/div/div/div/input")));
            inputValue.Click();
            inputValue.Clear();
            inputValue.SendKeys($"{value}");            
        }
        public static bool CheckInputValue(string value)
        {            
            string testValue = inputValue.GetAttribute("value");
            bool check = false;
            if (testValue == value)
            {
                check = true;
            }            
            return check;
        }
    }
}
//Keys.ARROW_UP И
//Keys.ARROW_DOWN
//i. Локатор By.tagName(“input”)