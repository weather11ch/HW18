using HW18.Factories;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;


namespace HW18.Pages
{
    internal class CheckBoxes : BasePage
    {        
        public static IWebElement checkBoxess;        
        public static List<IWebElement> checkBoxes = new List<IWebElement>();
        public static List<string> text = new List<string>();
        

        public static void OpenCheckBoxesPage()
        {           
            checkBoxess = Driver.WaitDriver(driver, 30).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"content\"]/ul/li[6]/a")));            
            checkBoxess.Click();
        }
               
        public static bool CheckBoxChecked(int k)
        {
            checkBoxes.Clear();
            checkBoxes = new List<IWebElement>();
            checkBoxes = Driver.GetDriver().FindElements(By.CssSelector("[type='checkbox']")).ToList();
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
            checkBoxes = Driver.GetDriver().FindElements(By.CssSelector("[type='checkbox']")).ToList();
            checkBoxes[k].Click();
        }

    }
}
