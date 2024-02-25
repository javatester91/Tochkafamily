using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace UI_test
{
    public class Base 
    {
        public IWebDriver driver;


        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://tochkafamily.ru/");
        }



        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}