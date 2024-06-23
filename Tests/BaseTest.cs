using HW18.Factories;
using HW18.Pages;


namespace HW18.Tests
{
    internal class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.GetDriver();
            Driver.WaitDriver(Driver.GetDriver(), 30);
            BasePage.OpenMainPage();
            Thread.Sleep(5000);
            
        }
        [TearDown]
        public void TearDown()
        {
            //BasePage.CloseMainPage();
            Driver.QuitDriver();
            //Driver.CloseDriver();
        }


    }
}
