using UI_test.PageObjects;

namespace UI_test
{
    [TestFixture]
    [Description("Проверка работы Главной страницы")]
    public class TestMainPageLinks : Base
    {
        [Test]
        [Description("Проверка работы ссылки Франшиза в попап меню")]
        public void Test()
        {
            var mainPage = new MainPage(driver);
            mainPage
            .PopapMenuFranshizaClick()
            .PopapMenuFranshizaClickLinkFranshiza();

            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Thread.Sleep(2000);
            string getUrl = driver.Url;
            Assert.AreEqual("https://fr-tochkafamily.ru/", getUrl);
            driver.Quit();
        }

        [Test]
        [Description("Проверка работы ссылки Франшиза на сайте")]
        public void Test1()
        {
            var mainPage = new MainPage(driver);
            mainPage
            .ScrollToElementFranshizaLink()
            .ClickLinkFranshiza();

            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Thread.Sleep(2000);
            string getUrl = driver.Url;
            Assert.AreEqual("https://fr-tochkafamily.ru/", getUrl);
            driver.Quit();
        }

        [Test]
        [Description("Проверка работы ссылки Работай с нами сайте")]
        public void Test2()
        {
            var mainPage = new MainPage(driver);
            mainPage
            .ScrollToLinkWorkWithUs()
            .ClickLinkWorkWithUs();

            string getUrl = driver.Url;
            Assert.AreEqual("https://tochkafamily.ru/content/rabota-v-tochke-krasoty", getUrl);
        }

        [Test]
        [Description("Проверка работы ссылки Учись с нами")]
        public void Test3()
        {
            var mainPage = new MainPage(driver);
            mainPage
            .ScrollToLinkWorkWithUs()
            .ClickLinkLearnWithUs();

            string getUrl = driver.Url;
            Assert.AreEqual("https://mone-academy.ru/", getUrl);
        }

        [Test]
        [Description("Проверка работы ссылки Каталог товаров")]
        public void Test4()
        {
            var mainPage = new MainPage(driver);
            mainPage
            .ScrollToLinkCatalog()
            .ClickLinkCatalog();

            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Thread.Sleep(2000);
            string getUrl = driver.Url;
            Assert.AreEqual("https://moneprofessional.ru/", getUrl);
            driver.Quit();
        }

        [Test]
        [Description("Проверка работы ссылки Запись")]
        public void Test5()
        {
            var mainPage = new MainPage(driver);
            mainPage
            .ClickRecord();

            //driver.SwitchTo().Window(driver.WindowHandles[1]);
            //Thread.Sleep(2000);
            //string getUrl = driver.Url;
            //Assert.AreEqual("https://moneprofessional.ru/", getUrl);
            //driver.Quit();
        }
    }
}