using OpenQA.Selenium;

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

        public MainPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }


        public void MenuFranshizaLinkClick()
        {
            _webDriver.FindElement(_menuFranshizaLink).Click();
            Thread.Sleep(1000);
        }

        public void MenuEducationLinkClick()
        {
            _webDriver.FindElement(_menuEducationLink).Click();
            Thread.Sleep(1000);
        }

        public JobPage MenuJobLinkClick()
        {
            _webDriver.FindElement(_menuJobLink).Click();
            Thread.Sleep(6000);
            return new JobPage(_webDriver);
        }

        public void MenuProductsLinkClick()
        {
            _webDriver.FindElement(_menuProductsLink).Click();
            Thread.Sleep(1000);
        }

        public void MenuEventsLinkClick()
        {
            _webDriver.FindElement(_menuEventsLink).Click();
            Thread.Sleep(1000);
        }

        public void MenuMapLinkClick()
        {
            _webDriver.FindElement(_menuMapLink).Click();
            Thread.Sleep(1000);
        }

        public void MenuContactsLinkClick()
        {
            _webDriver.FindElement(_menuContactsLink).Click();
            Thread.Sleep(1000);
        }
    }
}
