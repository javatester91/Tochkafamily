using OpenQA.Selenium;

namespace UI_test.PageObjects
{

    class MainPageRecordOnLine
    {
        private IWebDriver _webDriver;

        private readonly By BlockCity = By.XPath("//div[@data-locator='city_item_2']");

        private readonly By SearchFilial = By.XPath("//span[@class='form-input__before']/following::input[1]");
        private readonly By FilialAdress = By.XPath("//div[@class='information']");


        public MainPageRecordOnLine(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public MainPageRecordOnLine BlockCityClick()
        {
            _webDriver.FindElement(BlockCity).Click();
            return new MainPageRecordOnLine(_webDriver);
        }

        public MainPageRecordOnLine InputFilial()
        {
            _webDriver.FindElement(SearchFilial).SendKeys("Яна Райниса 2");
            Thread.Sleep(5000);
            return new MainPageRecordOnLine(_webDriver);
        }

        public MainPageRecordOnLine ChooseFilial()
        {
            _webDriver.FindElement(FilialAdress).Click();
            Thread.Sleep(10000);
            return new MainPageRecordOnLine(_webDriver);
        }
    }
}

