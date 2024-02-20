using UI_test.PageObjects;

namespace UI_test
{
    [TestFixture]
    [Description("Проверка работы ссылок Menu")]
    public class TestMenuLinks : Base
    {

        [Test]
        [Description("Проверка работы ссылки Франшиза")]
        public void TestMenuFranshizaLink()
        {
            var mainPage = new MainPage(driver);
            mainPage
                .MenuFranshizaLinkClick();

            string getUrl = driver.Url;
            Assert.That("https://fr-tochkafamily.ru/", Is.EqualTo( getUrl));
        }

        [Test]
        [Description("Проверка работы ссылки Работа")]
        public void TestMenuJobLink()
        {
            var mainPage = new MainPage(driver);
            mainPage
                .MenuJobLinkClick();

            string getUrl = driver.Url;
            Assert.That("https://tochkafamily.ru/content/rabota-v-tochke-krasoty", Is.EqualTo(getUrl));
        }

        [Test]
        [Description("Проверка работы ссылки Обучение")]
        public void TestMenuEducationLink()
        {
            var mainPage = new MainPage(driver);
            mainPage
                .MenuEducationLinkClick();

            string getUrl = driver.Url;
            Assert.That("https://mone-academy.ru/", Is.EqualTo(getUrl));
        }

        [Test]
        [Description("Проверка работы ссылки Продукция")]
        public void TestMenuProductsLink()
        {
            var mainPage = new MainPage(driver);
            mainPage
                .MenuProductsLinkClick();

            string getUrl = driver.Url;
            Assert.That("https://moneprofessional.ru/", Is.EqualTo(getUrl));
        }

        [Test]
        [Description("Проверка работы ссылки Мероприятия")]
        public void TestMenuEventsLink()
        {
            var mainPage = new MainPage(driver);
            mainPage
                .MenuEventsLinkClick();

            string getUrl = driver.Url;
            Assert.That("https://tochkafamily.ru/events", Is.EqualTo(getUrl));
        }

        [Test]
        [Description("Проверка работы ссылки Карта салонов")]
        public void TestMenuMapLink()
        {
            var mainPage = new MainPage(driver);
            mainPage
                .MenuMapLinkClick();

            string getUrl = driver.Url;
            Assert.That("https://tochkafamily.ru/#block-block-34", Is.EqualTo(getUrl));
        }

        [Test]
        [Description("Проверка работы ссылки Контакты")]
        public void TestMenuContactsLink()
        {
            var mainPage = new MainPage(driver);
            mainPage
                .MenuContactsLinkClick();

            string getUrl = driver.Url;
            Assert.That("https://tochkafamily.ru/content/kontakty", Is.EqualTo(getUrl));
        }
    }
}