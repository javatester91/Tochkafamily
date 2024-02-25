using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Xml.Linq;
using UI_Tests;

namespace UI_test.PageObjects
{

    class MainPageRecordOnLine
    {
        private IWebDriver driver;

        private readonly By BlockCity = By.XPath("//div[@data-locator='city_item_2']");

        private readonly By SearchFilial = By.XPath("//span[@class='form-input__before']/following::input[1]");
        private readonly By FilialAdress = By.XPath("//div[@class='information']");
        private readonly By ChooseSpecialistLocator = By.XPath("//div[text()[contains(.,'Выбрать специалиста')]]");
        private readonly By ChooseDateLocator = By.XPath("//div[text()[contains(.,'Выбрать дату и время')]]");
        private readonly By ChooseServiceLocator = By.XPath("//span[text()[contains(.,'Выбрать услуги')]]");
        private readonly By BackLocator = By.XPath("//ui-kit-svg-icon[@data-locator='header_small_button_back']");

        public MainPageRecordOnLine(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        public MainPageRecordOnLine BlockCityClick()
        {
            driver.FindElement(BlockCity).Click();
            return new MainPageRecordOnLine(driver);
        }

        public MainPageRecordOnLine InputFilial()
        {
            driver.FindElement(SearchFilial).SendKeys("Яна Райниса 2");

            return new MainPageRecordOnLine(driver);
        }

        public MainPageRecordOnLine ChooseFilial()
        {
            WaitUntil.WaitElement(driver, FilialAdress, 5);
            driver.FindElement(FilialAdress).Click();
            return new MainPageRecordOnLine(driver);
        }

        public MainPageRecordOnLine ChooseSpecialists()
        {
            driver.FindElement(ChooseSpecialistLocator).Click();
            return new MainPageRecordOnLine(driver);
        }

        public MainPageRecordOnLine ChooseDate()
        {
            driver.FindElement(ChooseDateLocator).Click();
            return new MainPageRecordOnLine(driver);
        }
        public MainPageRecordOnLine ChooseService()
        {
            driver.FindElement(ChooseServiceLocator).Click();
            return new MainPageRecordOnLine(driver);
        }

        public MainPageRecordOnLine ClickBack()
        {
            driver.FindElement(BackLocator).Click();
            return new MainPageRecordOnLine(driver);
        }
    }
}

