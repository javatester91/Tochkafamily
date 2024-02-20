using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace UI_test.PageObjects
{

    class MainPage
    {
        private IWebDriver _webDriver;

        private readonly By _menuFranshizaLink = By.XPath("//li[@class='first leaf']//a");
        private readonly By _menuEducationLink = By.XPath("//ul//li[2]//a");
        private readonly By _menuJobLink = By.XPath("//ul//li[3]//a");
        private readonly By _menuProductsLink = By.XPath("//ul//li[4]//a");
        private readonly By _menuEventsLink = By.XPath("//ul//li[5]//a");
        private readonly By _menuMapLink = By.XPath("//ul//li[6]//a");
        private readonly By _menuContactsLink = By.XPath("//li[@class='last leaf']//a");

        private readonly By block_franshiza = By.XPath("//div[@class='franchize-slide-chevron']");
        private readonly By link_franshizaPopapMenu = By.XPath("//div[@id='block-block-32']//a");

        private readonly By link_franshizaLinkSite = By.PartialLinkText("ПОДРОБНЕЕ");
        private readonly By link_workWithUs = By.XPath("//span[contains(text(), 'Работай с нами')]");
        private readonly By link_learnWithUs = By.XPath("//span[contains(text(), 'Учись с нами')]");

        private readonly By link_Catalog = By.Id("moneprof_footer");
        
        public MainPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        // Скрол до ссылки Франшиза на сайте
        public MainPage ScrollToElementFranshizaLink()
        {
            IWebElement link = _webDriver.FindElement(link_franshizaLinkSite);
            new Actions(_webDriver)
                .ScrollToElement(link)
                .Perform();
            return this;
        }

        // Скрол до ссылки Каталог на сайте
        public MainPage ScrollToLinkCatalog()
        {
            IWebElement link = _webDriver.FindElement(link_Catalog);
            new Actions(_webDriver)
                .ScrollToElement(link)
                .Perform();
            return this;
        }

        // Скрол до ссылки Работай с нами
        public MainPage ScrollToLinkWorkWithUs()
        {
            IWebElement link = _webDriver.FindElement(link_workWithUs);
            new Actions(_webDriver)
                .ScrollToElement(link)
                .Perform();
            return this;
        }


        // Клик на ссылку меню Франшиза
        public void MenuFranshizaLinkClick()
        {
            _webDriver.FindElement(_menuFranshizaLink).Click();
            Thread.Sleep(1000);
        }

        // Клик на ссылку меню Обучение
        public void MenuEducationLinkClick()
        {
            _webDriver.FindElement(_menuEducationLink).Click();
            Thread.Sleep(1000);
        }

        // Клик на ссылку меню Работа
        public JobPage MenuJobLinkClick()
        {
            _webDriver.FindElement(_menuJobLink).Click();
            Thread.Sleep(6000);
            return new JobPage(_webDriver);
        }

        // Клик на ссылку меню Продукция
        public void MenuProductsLinkClick()
        {
            _webDriver.FindElement(_menuProductsLink).Click();
            Thread.Sleep(1000);
        }

        // Клик на ссылку меню Мероприятия
        public void MenuEventsLinkClick()
        {
            _webDriver.FindElement(_menuEventsLink).Click();
            Thread.Sleep(1000);
        }

        // Клик на ссылку меню Карта салонов
        public void MenuMapLinkClick()
        {
            _webDriver.FindElement(_menuMapLink).Click();
            Thread.Sleep(1000);
        }

        // Клик на ссылку меню Контакты
        public void MenuContactsLinkClick()
        {
            _webDriver.FindElement(_menuContactsLink).Click();
            Thread.Sleep(1000);
        }

        // Клик на попап меню Франшиза
        public MainPage PopapMenuFranshizaClick()
        {
            _webDriver.FindElement(block_franshiza).Click();
            Thread.Sleep(1000);
            return new MainPage(_webDriver);
        }

        // Клик на ссылку Франшизы в попап меню Франшиза
        public MainPage PopapMenuFranshizaClickLinkFranshiza()
        {
            _webDriver.FindElement(link_franshizaPopapMenu).Click();
            Thread.Sleep(2000);
            return new MainPage(_webDriver);
        }

        // Клик на ссылку Подробнее в блоке сайта Франшиза
        public void ClickLinkFranshiza()
        {
            _webDriver.FindElement(link_franshizaLinkSite).Click();
        }

        // Клик на ссылку Работай с нами
        public void ClickLinkWorkWithUs()
        {
            _webDriver.FindElement(link_workWithUs).Click();
            Thread.Sleep(2000);
        }

        // Клик на ссылку Учись с нами
        public void ClickLinkLearnWithUs()
        {
            _webDriver.FindElement(link_learnWithUs).Click();
            Thread.Sleep(2000);
        }

        // Клик на ссылку Каталог
        public void ClickLinkCatalog()
        {
            _webDriver.FindElement(link_Catalog).Click();
            Thread.Sleep(2000);
        }
    }
}
