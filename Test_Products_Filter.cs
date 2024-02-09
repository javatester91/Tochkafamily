global using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Xml.Linq;

namespace UI_test
{
    public class Test_Products_Filter : Base
    {
        private readonly By MenuLinkJob = By.XPath("//ul//li[4]//a");
        
        private readonly By LinkCatalog = By.XPath("//li[@class='second-li']//a");
        private readonly By LinkAllProducts = By.XPath("//li[@class='second-li']//ul//li[1]");
        private readonly By CheckboxShampoo = By.Id("arrFilter_20_4088188550");
        private readonly By ButtonShow = By.Id("set_filter1");
        


        [Test]
        public void Test_Job()
        {
            driver.FindElement(MenuLinkJob).Click();
            var elementMenuCatalog = driver.FindElement(LinkCatalog);
            Actions action = new Actions(driver);
            action.MoveToElement(elementMenuCatalog);
            action.Perform();
            driver.FindElement(LinkAllProducts).Click();
            driver.FindElement(CheckboxShampoo).Click();
            var elementButtonShow = driver.FindElement(ButtonShow);
            action.MoveToElement(elementButtonShow);
            action.Perform();
            Thread.Sleep(2000);
            elementButtonShow.Click();
            Thread.Sleep(2000);
            string getUrl = driver.Url;
            Assert.AreEqual("https://moneprofessional.ru/katalog/vse-produkty/cat_shampoos/", getUrl);

        }

    }
}