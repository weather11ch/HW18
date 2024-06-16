using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace HW18.Factories
{
    internal class Driver
    {
        public static IWebDriver? _driver;

        public static WebDriverWait? _wait;
               
        public static IWebDriver GetDriver() => _driver ??= SetupDriver();
        public static WebDriverWait WaitDriver(IWebDriver driver, double waitTime) => _wait ??= new WebDriverWait(driver, TimeSpan.FromSeconds(waitTime));

        //обнуление драйвера
        public static void QuitDriver()
        {
            _driver.Quit();
            _driver = null;
        }

         private static IWebDriver SetupDriver() => _driver ??= new ChromeDriver();




        
    }
}
