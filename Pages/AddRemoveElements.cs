using HW18.Factories;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Security.Principal;


namespace HW18.Pages
{
    internal class AddRemoveElements : BasePage

    {        
        public static IWebElement buttonAddElement;     
        public static IWebElement buttonDelete;
        public static List<IWebElement> countDeletes = new List<IWebElement>();

        private static IWebElement addRemoveElements = driver.FindElement(By.XPath("//*[@href='/add_remove_elements/']"));

        public static void OpenAddRemoveElements()
        {
            addRemoveElements.Click();
        }
        public static void AddElement()
        {
            buttonAddElement = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[text()='Add Element']")));
            buttonAddElement.Click();

        }             
        
        public static void DeleteElementButton()
        {
            buttonDelete = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[text()='Delete']")));
            buttonDelete.Click();
        }
        public static int CountElementsDelete()
        {
            countDeletes.Clear();
            countDeletes = new List<IWebElement>();
            countDeletes = driver.FindElements(By.XPath("//button[text()='Delete']")).ToList();
            int count = countDeletes.Count;
            return count;
        }


    }
}

//добавить 2 элемента, удалить элемент,
//проверить количество элементов
//i. Локаторы xpath:
//1.By.xpath("//button[text()='Add Element']")
//2.By.xpath("//button[text()='Delete']")