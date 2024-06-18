using HW18.Factories;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace HW18.Pages
{
    internal class AddRemoveElements : BasePage

    {        
        public static IWebElement buttonAddElement;     
        public static IWebElement buttonDelete;
        public static List<IWebElement> countDeletes = new List<IWebElement>();

        private static IWebElement addRemoveElements; 

        public static void OpenAddRemoveElements()
        {            
            addRemoveElements = Driver.WaitDriver(driver, 30).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@href='/add_remove_elements/']")));
            addRemoveElements.Click();
        }
        public static void AddElement()
        {
            buttonAddElement = Driver.WaitDriver(driver, 30).Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[text()='Add Element']")));
            buttonAddElement.Click();

        }             
        
        public static void DeleteElementButton()
        {
            buttonDelete = Driver.WaitDriver(driver, 30).Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[text()='Delete']")));
            buttonDelete.Click();
        }
        public static int CountElementsDelete()
        {
            countDeletes.Clear();
            countDeletes = new List<IWebElement>();
            countDeletes = Driver.GetDriver().FindElements(By.XPath("//button[text()='Delete']")).ToList();
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