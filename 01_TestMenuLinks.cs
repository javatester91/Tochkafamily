global using NUnit.Framework;
using OpenQA.Selenium;
using UI_test.PageObjects;

namespace UI_test
{
    public class TestMenuLinks : Base
    {

        [Test]
        public void TestMenuFranshizaLink()
        {
            var mainPage = new MainPage(driver);
            mainPage
                .MenuFranshizaLinkClick();

            string getUrl = driver.Url;
            Assert.AreEqual("https://fr-tochkafamily.ru/", getUrl);
        }

        [Test]
        public void TestMenuJobLink()
        {
            var mainPage = new MainPage(driver);
            mainPage
                .MenuJobLinkClick();

            string getUrl = driver.Url;
            Assert.AreEqual("https://tochkafamily.ru/content/rabota-v-tochke-krasoty", getUrl);
        }

        [Test]
        public void TestMenuEducationLink()
        {
            var mainPage = new MainPage(driver);
            mainPage
                .MenuEducationLinkClick();

            string getUrl = driver.Url;
            Assert.AreEqual("https://mone-academy.ru/", getUrl);
        }

        [Test]
        public void TestMenuProductsLink()
        {
            var mainPage = new MainPage(driver);
            mainPage
                .MenuProductsLinkClick();

            string getUrl = driver.Url;
            Assert.AreEqual("https://moneprofessional.ru/", getUrl);
        }

        [Test]
        public void TestMenuEventsLink()
        {
            var mainPage = new MainPage(driver);
            mainPage
                .MenuEventsLinkClick();

            string getUrl = driver.Url;
            Assert.AreEqual("https://tochkafamily.ru/events", getUrl);
        }

        [Test]
        public void TestMenuMapLink()
        {
            var mainPage = new MainPage(driver);
            mainPage
                .MenuMapLinkClick();

            string getUrl = driver.Url;
            Assert.AreEqual("https://tochkafamily.ru/#block-block-34", getUrl);
        }

        [Test]
        public void TestMenuContactsLink()
        {
            var mainPage = new MainPage(driver);
            mainPage
                .MenuContactsLinkClick();

            string getUrl = driver.Url;
            Assert.AreEqual("https://tochkafamily.ru/content/kontakty", getUrl);
        }
    }
}