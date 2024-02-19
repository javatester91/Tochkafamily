using OpenQA.Selenium;
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
    }
}