global using NUnit.Framework;
using OpenQA.Selenium;

namespace UI_test
{
    public class TestMainPageLinks : Base
    {
        private readonly By block_franshiza = By.XPath("//div[@class='franchize-slide-chevron']");
        private readonly By link_franshiza = By.XPath("//div[@id='block-block-32']//a");
        
        [Test]
        public void Test()
        {
            var blockFranshiza = driver.FindElement(block_franshiza);
            blockFranshiza.Click();
            Thread.Sleep(1000);
            var linkFranshiza = driver.FindElement(link_franshiza);
            linkFranshiza.Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Thread.Sleep(2000);
            string getUrl = driver.Url;
            Assert.AreEqual("https://fr-tochkafamily.ru/", getUrl);
        }
    }
}