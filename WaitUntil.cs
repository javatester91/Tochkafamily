using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Tests
{
    public static class WaitUntil
    {
        public static void WaitElement(IWebDriver driver, By locator, int seconds) 
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until(d => d.FindElement(locator));
        }

        public static void WaitSomeInterval(int seconds) 
        {
            Thread.Sleep(seconds);
        }
    }
}
